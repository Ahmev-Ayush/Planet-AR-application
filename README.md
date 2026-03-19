# Planets AR

An interactive mobile AR project built in Unity where users can place and explore space-themed objects in the real world.

## Project Overview

Planets AR is a markerless augmented reality experience focused on planetary exploration scenes. The app combines scene-based navigation with simple and clear interactions:

- Switch between themed scenes from a home screen.
- Rotate planets continuously for a dynamic feel.
- Move objects along world axes with button-based controls.
- Resize planets with smooth animated scaling and safe min/max limits.
- Animate satellite/ship motion with cleanup logic to remove objects after threshold limits.

## Tech Stack

- Engine: Unity 6 (6000.2.6f2)
- AR: AR Foundation 6.2.0
- Platform XR: ARCore 6.2.0, ARKit 6.2.0
- Interaction: XR Interaction Toolkit 3.2.1
- Rendering: Universal Render Pipeline (URP)
- Input: Unity Input System

## Core Scripts

- `Assets/Scripts/SceneController.cs`: Scene switching from UI.
- `Assets/Scripts/RotatePlanet.cs`: Per-frame object rotation.
- `Assets/Scripts/TranslatePlanet.cs`: Axis translation controls (+ optional auto movement and destroy threshold).
- `Assets/Scripts/ResizePlanet.cs`: Animated uniform scaling with easing and clamp range.
- `Assets/Scripts/translateShip.cs`: Ship translation with z-threshold destroy logic.

## Scenes and Media Placeholders

Use the links below as placeholders. Replace each URL with your actual screenshots, GIFs, or demo videos.

### 1) HomeScreen

- Scene file: `Assets/Scenes/HomeScreen.unity`
- Hero screenshot: [Replace link](https://example.com/planets-ar/homescreen/hero.png)
- UI closeup: [Replace link](https://example.com/planets-ar/homescreen/ui-closeup.png)
- Short demo video: [Replace link](https://example.com/planets-ar/homescreen/demo.mp4)

### 2) Earth Scene

- Scene file: `Assets/Scenes/earthScene.unity`
- Surface/detail shot: [Replace link](https://example.com/planets-ar/earth/planet-detail.png)
- Interaction screenshot: [Replace link](https://example.com/planets-ar/earth/interaction.png)
- Short demo video: [Replace link](https://example.com/planets-ar/earth/demo.mp4)

### 3) Mars Scene

- Scene file: `Assets/Scenes/marsScene.unity`
- Surface/detail shot: [Replace link](https://example.com/planets-ar/mars/planet-detail.png)
- Interaction screenshot: [Replace link](https://example.com/planets-ar/mars/interaction.png)
- Short demo video: [Replace link](https://example.com/planets-ar/mars/demo.mp4)

### 4) Jupiter Scene

- Scene file: `Assets/Scenes/jupiterScene.unity`
- Surface/detail shot: [Replace link](https://example.com/planets-ar/jupiter/planet-detail.png)
- Interaction screenshot: [Replace link](https://example.com/planets-ar/jupiter/interaction.png)
- Short demo video: [Replace link](https://example.com/planets-ar/jupiter/demo.mp4)

### 5) Saturn Scene

- Scene file: `Assets/Scenes/saturnScene.unity`
- Ring closeup shot: [Replace link](https://example.com/planets-ar/saturn/rings-closeup.png)
- Interaction screenshot: [Replace link](https://example.com/planets-ar/saturn/interaction.png)
- Short demo video: [Replace link](https://example.com/planets-ar/saturn/demo.mp4)

### 6) Black Hole Scene

- Scene file: `Assets/Scenes/blackholeScene.unity`
- Visual effect shot: [Replace link](https://example.com/planets-ar/blackhole/effect.png)
- Interaction screenshot: [Replace link](https://example.com/planets-ar/blackhole/interaction.png)
- Short demo video: [Replace link](https://example.com/planets-ar/blackhole/demo.mp4)

### 7) Satellite Scene

- Scene file: `Assets/Scenes/satelliteScene.unity`
- Model closeup: [Replace link](https://example.com/planets-ar/satellite/model-closeup.png)
- Interaction screenshot: [Replace link](https://example.com/planets-ar/satellite/interaction.png)
- Short demo video: [Replace link](https://example.com/planets-ar/satellite/demo.mp4)

## What I Learned

Building this project helped me improve in several practical AR and Unity areas:

- How to structure a scene-based AR app with clear UI navigation.
- How to keep interactions simple for mobile users (tap buttons, predictable movement, smooth scaling).
- How to clamp transform values to avoid unstable AR behavior (especially object scale).
- How to use animation curves and coroutines to make UI-driven actions feel polished.
- How to separate behavior by script responsibility (scene control, rotate, translate, resize).
- How to think about cleanup/performance by destroying objects after threshold conditions.
- How to integrate AR Foundation with ARCore/ARKit for cross-platform AR workflows.

## How to Run

1. Open the project in Unity Editor 6000.2.6f2.
2. Open `Assets/Scenes/HomeScreen.unity`.
3. Verify XR/AR packages are installed (AR Foundation, ARCore/ARKit, XR Interaction Toolkit).
4. Build to Android or iOS with camera permissions enabled.

## Future Improvements

- Add orbit trajectories and live scale comparison UI.
- Add educational overlays (planet facts, atmospheric stats, missions).
- Add gesture-based interactions in addition to button controls.
- Add scene-level lighting profiles to improve realism across environments.
- Replace all placeholder media links with production captures.

## Notes

- This repo contains build backup folders under `Apk/`; keep them out of production releases.
- If needed, add a dedicated section for APK download and release changelog.
