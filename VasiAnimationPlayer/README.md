# Vasi Animation Player

## Overview
The Vasi Animation Player is a Unity package designed to facilitate the playback of .vasi animations within Unity projects. This package includes the necessary scripts and editor tools to load, configure, and play animations seamlessly.

## Files Included
- **Assets/Scripts/VasiAnimationPlayer.cs**: Contains the `VasiAnimationPlayer` class responsible for playing .vasi animations. It provides methods to initialize, play, and stop animations using coroutines for smooth playback.
  
- **Assets/Scripts/VasiAnimation.cs**: Defines the `VasiAnimation` class, which represents the .vasi animation data. This class includes methods to load animation data from .vasi files and manage the playback of animation frames.

- **Assets/Editor/VasiAnimationEditor.cs**: Implements a custom editor for the `VasiAnimation` class, allowing users to load and configure .vasi animations directly within the Unity Editor interface.

- **package.json**: Configuration file for npm, listing dependencies and scripts required for the project, including any necessary Unity packages.

## Usage
1. **Installation**: Import the Vasi Animation Player package into your Unity project.
2. **Setup**: Create a new GameObject and attach the `VasiAnimationPlayer` component.
3. **Load Animation**: Use the `VasiAnimation` class to load your .vasi animation files.
4. **Play Animation**: Call the `Play()` method on the `VasiAnimationPlayer` instance to start the animation.
5. **Stop Animation**: Call the `Stop()` method to halt the animation playback.

## Creating .vasi Animations
To create .vasi animations, you will need to define your animation frames and save them in the .vasi format. Use the provided editor tools to assist in loading and configuring your animations.

## License
This project is licensed under the MIT License. See the LICENSE file for more details.