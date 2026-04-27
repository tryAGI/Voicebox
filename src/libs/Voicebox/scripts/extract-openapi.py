#!/usr/bin/env python3
"""Extract Voicebox's FastAPI OpenAPI schema without loading ML runtimes."""

from __future__ import annotations

import json
import sys
import types
from pathlib import Path
from typing import Any


def _module(name: str, **attrs: Any) -> types.ModuleType:
    module = types.ModuleType(name)
    for attr_name, value in attrs.items():
        setattr(module, attr_name, value)
    return module


def _install_runtime_stubs() -> None:
    torch = _module("torch")
    torch.cuda = types.SimpleNamespace(
        is_available=lambda: False,
        get_device_name=lambda index=0: "Unavailable",
    )
    torch.backends = types.SimpleNamespace(
        mps=types.SimpleNamespace(is_available=lambda: False),
    )
    torch.version = types.SimpleNamespace(hip=None)
    sys.modules["torch"] = torch

    services = _module("backend.services")
    services.__path__ = []
    sys.modules["backend.services"] = services

    service_names = [
        "captures",
        "channels",
        "cuda",
        "effects",
        "export_import",
        "generation",
        "history",
        "llm",
        "personality",
        "profiles",
        "refinement",
        "settings",
        "stories",
        "task_queue",
        "transcribe",
        "tts",
    ]
    for service_name in service_names:
        module = _module(f"backend.services.{service_name}")
        sys.modules[f"backend.services.{service_name}"] = module
        setattr(services, service_name, module)

    sys.modules["backend.services.refinement"].RefinementFlags = object
    sys.modules["backend.services.profiles"]._profile_to_response = lambda *args, **kwargs: None
    sys.modules["backend.services.generation"].run_generation = lambda *args, **kwargs: None

    task_queue = sys.modules["backend.services.task_queue"]
    task_queue.create_background_task = lambda *args, **kwargs: None
    task_queue.init_queue = lambda *args, **kwargs: None
    task_queue.cancel_generation = lambda *args, **kwargs: None
    task_queue.enqueue_generation = lambda *args, **kwargs: None

    backends = _module(
        "backend.backends",
        get_llm_model_configs=lambda: [],
        get_stt_model_configs=lambda: [],
    )
    sys.modules["backend.backends"] = backends
    sys.modules["backend.backends.base"] = _module(
        "backend.backends.base",
        is_model_cached=lambda *args, **kwargs: False,
        check_cuda_compatibility=lambda *args, **kwargs: (True, None),
    )

    sys.modules["backend.utils.progress"] = _module(
        "backend.utils.progress",
        get_progress_manager=lambda: types.SimpleNamespace(_set_main_loop=lambda *args, **kwargs: None),
    )
    sys.modules["backend.utils.cache"] = _module(
        "backend.utils.cache",
        clear_voice_prompt_cache=lambda: None,
    )
    sys.modules["backend.utils.tasks"] = _module(
        "backend.utils.tasks",
        get_task_manager=lambda: types.SimpleNamespace(),
    )
    sys.modules["backend.utils.audio"] = _module(
        "backend.utils.audio",
        load_audio=lambda *args, **kwargs: None,
        save_audio=lambda *args, **kwargs: None,
        validate_and_load_reference_audio=lambda *args, **kwargs: None,
    )
    sys.modules["backend.utils.images"] = _module(
        "backend.utils.images",
        process_avatar=lambda *args, **kwargs: None,
        validate_image=lambda *args, **kwargs: None,
    )

    mcp_package = _module("backend.mcp_server")
    mcp_package.__path__ = []
    sys.modules["backend.mcp_server"] = mcp_package

    class DummyMcp:
        def http_app(self, path: str = "/", transport: str = "http"):
            from fastapi import FastAPI

            return FastAPI()

    sys.modules["backend.mcp_server.server"] = _module(
        "backend.mcp_server.server",
        build_mcp_server=lambda: DummyMcp(),
        compose_lifespan=lambda *contexts: contexts[0],
        mount_into=lambda *args, **kwargs: None,
    )

    class ClientIdMiddleware:
        def __init__(self, app):
            self.app = app

        async def __call__(self, scope, receive, send):
            await self.app(scope, receive, send)

    sys.modules["backend.mcp_server.context"] = _module(
        "backend.mcp_server.context",
        ClientIdMiddleware=ClientIdMiddleware,
    )

    mcp_events = _module(
        "backend.mcp_server.events",
        event_bus=types.SimpleNamespace(subscribe=lambda: None),
    )
    mcp_resolve = _module(
        "backend.mcp_server.resolve",
        resolve_profile=lambda *args, **kwargs: None,
    )
    sys.modules["backend.mcp_server.events"] = mcp_events
    sys.modules["backend.mcp_server.resolve"] = mcp_resolve
    mcp_package.events = mcp_events
    mcp_package.resolve = mcp_resolve


def main() -> int:
    if len(sys.argv) != 3:
        print("Usage: extract-openapi.py <voicebox-repo> <output-json>", file=sys.stderr)
        return 2

    repo = Path(sys.argv[1]).resolve()
    output = Path(sys.argv[2]).resolve()

    sys.path.insert(0, str(repo))
    _install_runtime_stubs()

    from backend.app import app

    spec = app.openapi()
    with output.open("w", encoding="utf-8") as f:
        json.dump(spec, f, indent=2, sort_keys=True)
        f.write("\n")

    return 0


if __name__ == "__main__":
    raise SystemExit(main())
