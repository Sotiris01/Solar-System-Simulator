# Solar System Simulator 🌌

A 3D interactive solar system simulator built with Unity where players can explore and interact with planets using meteor projectiles.

## 🎮 Game Features

### Core Gameplay
- **3D Solar System**: Navigate through a realistic solar system with planets orbiting around the sun
- **Player Movement**: Free-roam 3D movement using WASD keys and mouse scroll
- **Meteor Launcher**: Press SPACE to fire meteors towards the sun
- **Planetary Destruction**: Meteors can destroy planets, creating spectacular fragment effects
- **Realistic Physics**: All objects follow physics-based movement and collisions

### Included Planets
- Sun (central star)
- Mercury
- Venus
- Earth
- Mars
- Jupiter
- Saturn

## 🕹️ Controls

| Input | Action |
|-------|--------|
| `W/A/S/D` | Move around the solar system |
| `Mouse Scroll` | Move forward/backward |
| `Space` | Fire meteor |
| `Mouse` | Camera automatically looks at the sun |

## 🎯 How to Play

1. **Explore**: Use WASD and mouse scroll to navigate around the solar system
2. **Aim**: Your view is always directed towards the sun
3. **Fire**: Press SPACE to launch meteors from your position
4. **Destroy**: Watch as meteors hit planets, creating beautiful destruction effects with fragments
5. **Physics**: Meteors have random sizes (1-10x scale) and travel towards the sun

## 💥 Destruction System

- **Planet Hit**: When a meteor hits a planet, the planet is destroyed and spawns 30 colorful fragments
- **Sun Hit**: When a meteor reaches the sun, it creates 20 fragments
- **Fragment Physics**: All fragments have random velocities and disappear after 3 seconds

## 🛠️ Technical Details

### Built With
- **Unity 3D** - Game engine
- **C#** - Programming language
- **3D Physics** - Rigidbody components for realistic movement

### Scripts Overview
- `playerMovement.cs` - Handles player camera and movement controls
- `planet_movement.cs` - Controls planetary orbiting around the sun
- `meteor_movement.cs` - Manages meteor physics and collision detection
- `fire_meteor.cs` - Handles meteor spawning when space is pressed
- `fragment_script.cs` - Controls fragment behavior and lifetime

## 📁 Project Structure

```
Assets/
├── Materials/          # Planet and object textures
├── Scenes/            # Main game scene
├── scripts/           # All C# game logic
├── textures/          # Texture assets
├── fragment.prefab    # Fragment prefab for destruction effects
└── meteor.prefab      # Meteor projectile prefab
```

## 🚀 Setup Instructions

1. **Clone the repository**
   ```bash
   git clone [your-repo-url]
   ```

2. **Open in Unity**
   - Open Unity Hub
   - Click "Open Project"
   - Select the cloned folder
   - Unity version used: [Add your Unity version]

3. **Run the Game**
   - Open the `mainScene` in the Scenes folder
   - Press the Play button in Unity Editor

## 🎓 Educational Purpose

This project was created as part of a Computer Graphics course assignment, demonstrating:
- 3D scene management
- Physics simulation
- Collision detection
- Particle effects
- Player input handling
- Object instantiation and destruction

## 📋 Requirements

- Unity 3D (recommended version: 2020.3 LTS or later)
- Windows/Mac/Linux compatible

## 🤝 Contributing

This is an educational project, but feel free to fork and experiment with:
- Adding more planets or celestial bodies
- Implementing different meteor types
- Creating power-ups or special effects
- Adding sound effects and music

## 📄 License

This project is for educational purposes. Feel free to use and modify for learning.

---

*Developed as part of Computer Graphics coursework at University of Ioannina* 🎓
