#!/usr/bin/env python3
"""Sample application for MCP agent testing."""

import json
import os

def load_config(path: str = "config.json") -> dict:
    """Load configuration from JSON file."""
    with open(path, 'r') as f:
        return json.load(f)

def main():
    """Main entry point."""
    config = load_config()
    print(f"Starting application with config: {config}")
    # TODO: Add actual application logic here

if __name__ == "__main__":
    main()
