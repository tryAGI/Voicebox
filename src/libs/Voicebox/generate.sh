#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: extracted from the upstream Voicebox FastAPI app.
# Voicebox also keeps docs/openapi.json in the repository, but that file can lag
# behind the current router set. This script generates from backend.app when
# possible and falls back to docs/openapi.json if upstream extraction breaks.
#
# Environment variables:
#   VOICEBOX_OPENAPI_URL       Full spec URL override, e.g. http://127.0.0.1:17493/openapi.json
#   VOICEBOX_REPOSITORY_URL    Upstream repo URL (default: https://github.com/jamiepine/voicebox.git)
#   VOICEBOX_REPOSITORY_REF    Upstream ref to inspect (default: main)
#   VOICEBOX_BASE_URL          Generated client default base URL (default: http://127.0.0.1:17493)

script_dir="$(cd -- "$(dirname -- "${BASH_SOURCE[0]}")" && pwd)"
cd "${script_dir}"

dotnet tool install --global autosdk.cli --prerelease

voicebox_repository_url="${VOICEBOX_REPOSITORY_URL:-https://github.com/jamiepine/voicebox.git}"
voicebox_repository_ref="${VOICEBOX_REPOSITORY_REF:-main}"
voicebox_openapi_url="${VOICEBOX_OPENAPI_URL:-}"
voicebox_base_url="${VOICEBOX_BASE_URL:-http://127.0.0.1:17493}"

temp_dir="$(mktemp -d)"
raw_openapi="${temp_dir}/openapi.raw.json"
repo_dir="${temp_dir}/voicebox"

cleanup() {
  rm -rf "${temp_dir}"
}

trap cleanup EXIT

format_openapi() {
  python3 - "${raw_openapi}" openapi.json <<'PY'
import json
import sys
from pathlib import Path

source = Path(sys.argv[1])
target = Path(sys.argv[2])

with source.open("r", encoding="utf-8") as f:
    spec = json.load(f)

with target.open("w", encoding="utf-8") as f:
    json.dump(spec, f, indent=2, sort_keys=True)
    f.write("\n")
PY
}

fetch_fallback_openapi() {
  curl -fsSL "https://raw.githubusercontent.com/jamiepine/voicebox/${voicebox_repository_ref}/docs/openapi.json" \
    -o "${raw_openapi}"
  format_openapi
}

if [ -n "${voicebox_openapi_url}" ]; then
  curl -fsSL "${voicebox_openapi_url}" -o "${raw_openapi}"
  format_openapi
else
  git clone --depth 1 "${voicebox_repository_url}" "${repo_dir}"
  if [ "${voicebox_repository_ref}" != "main" ]; then
    git -C "${repo_dir}" fetch --depth 1 origin "${voicebox_repository_ref}"
    git -C "${repo_dir}" checkout --detach FETCH_HEAD
  fi

  venv_dir="${temp_dir}/venv"
  python3 -m venv "${venv_dir}"
  "${venv_dir}/bin/python" -m pip install --disable-pip-version-check -q \
    "fastapi>=0.109.0" \
    "sqlalchemy>=2.0.0" \
    "python-multipart>=0.0.6" \
    "sse-starlette>=2.0"

  if ! "${venv_dir}/bin/python" scripts/extract-openapi.py "${repo_dir}" "${raw_openapi}"; then
    echo "Failed to extract live Voicebox OpenAPI spec; falling back to docs/openapi.json." >&2
    fetch_fallback_openapi
  else
    format_openapi
  fi
fi

rm -rf Generated

autosdk generate openapi.json \
  --namespace Voicebox \
  --clientClassName VoiceboxClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --base-url "${voicebox_base_url}"
