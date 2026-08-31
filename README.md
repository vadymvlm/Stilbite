## Quick Links

- [Overview](#overview)
- [Get Started](#get-started)
- [Source Navigation Overview](#source-navigation-overview)
- [Wiki](https://github.com/vadymvlm/Stilbite/wiki)

## Overview

Third-person multiplayer 3D shooter for Android and iOS with online infrastructure.

## Get Started

After cloning the project, follow these steps:
1. Unity ([version](./Stilbite/ProjectSettings/ProjectVersion.txt)) with all required Build Support modules
   - Android
   - iOS
   - Linux Dedicated Server
2. Clone and remove the `.origin` suffix from [ProjectSettings.asset.origin](./Stilbite/ProjectSettings/ProjectSettings.asset.origin) to create `ProjectSettings.asset`.
3. After making changes in the Project Settings, merge changes from `ProjectSettings.asset` into [ProjectSettings.asset.origin](./Stilbite/ProjectSettings/ProjectSettings.asset.origin), excluding any credentials.
4. Add Firebase credentials.
5. Connect to the Cloud Project and select the Editor environment.

## Source Navigation Overview

- [Online](./Online): backend and battle servers online infrastructure.
- [Backend](./Backend): metagame and push-notification services.
- [Stilbite](./Stilbite): game client and/or headless/dedicated authoritative battle server.
   - [Shared](./Stilbite/Assets/Shared): core simulation and logic.
   - [Server](./Stilbite/Assets/Server): AI, behavior and specific logic.
   - [Editor](./Stilbite/Assets/Editor): editor scripts.