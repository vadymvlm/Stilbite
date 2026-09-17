## Quick Links

- [Overview](#overview)
- [Get Started](#get-started)
- [Source Navigation Overview](#source-navigation-overview)
- [Wiki](https://github.com/vadymvlm/Stilbite/wiki)

## Overview

Third-person multiplayer 3D shooter for Android and iOS with online infrastructure.

## Get Started

Before cloning the project, follow these steps:
1. Install Unity ([version](./Stilbite/ProjectSettings/ProjectVersion.txt)) with all required Build Support modules
   - Android
   - iOS
   - Linux Dedicated Server

After cloning the project, follow these steps:
1. Clone and remove the `.origin` suffix from [ProjectSettings.asset.origin](./Stilbite/ProjectSettings/ProjectSettings.asset.origin) to create `ProjectSettings.asset`.
2. After making changes in the Project Settings, merge changes from `ProjectSettings.asset` into [ProjectSettings.asset.origin](./Stilbite/ProjectSettings/ProjectSettings.asset.origin), and set empty value for `organizationId` `cloudProjectId`.
3. Connect to the Cloud Project and select the Editor environment.
4. Add Firebase credentials.

## Source Navigation Overview

- [Online](./Online): game online implementation.
   - [Online](./Online/Online): metagame and notification services, auto-scaled battle servers (compute VMs).
   - [Shared](./Online/Shared): shared models between client and online.
   - [BattleService](./Online/BattleService): battle instances management.
- [Stilbite](./Stilbite): game client and/or dedicated authoritative battle instance.
   - [Shared](./Stilbite/Assets/Shared): gameplay simulation and logic.
   - [Server](./Stilbite/Assets/Server): AI, behavior and specific logic.