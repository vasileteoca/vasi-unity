# VasiAnimationProject

## Overview
VasiAnimationProject is a Unity project designed to handle Vasi animation files for use in 2D games. This project includes a library for loading, parsing, and playing animations defined in the Vasi format.

## Project Structure
```
VasiAnimationProject
├── Assets
│   ├── Scripts
│   │   ├── VasiAnimation.cs
│   │   └── VasiAnimationLibrary
│   │       ├── VasiAnimationLoader.cs
│   │       └── VasiAnimationPlayer.cs
│   ├── Resources
│   │   └── Animations
│   │       └── example.vasi
│   └── Scenes
│       └── MainScene.unity
├── ProjectSettings
├── Packages
├── README.md
└── VasiAnimationProject.sln
```

## Setup Instructions
1. **Clone the Repository**: Clone this project to your local machine.
2. **Open in Unity**: Open the project in the Unity Editor.
3. **Load Animations**: Use the `VasiAnimationLoader` class to load your Vasi animation files from the specified path.
4. **Play Animations**: Utilize the `VasiAnimationPlayer` class to manage and play the loaded animations.

## Usage Guidelines
- Ensure your Vasi animation files are formatted correctly to be parsed by the `VasiAnimationLoader`.
- Use the `VasiAnimation` class to integrate animations into your game objects.
- Test animations in the `MainScene.unity` to visualize their playback.

## Example Animation
An example Vasi animation file is provided in `Assets/Resources/Animations/example.vasi`. Modify this file to create your own animations.

## License
This project is open-source and available for modification and distribution under the terms of the MIT License.