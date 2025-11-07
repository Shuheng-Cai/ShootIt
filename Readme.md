# Shoot It - Unity 2D Shooter Game 🎮

A top-down 2D shooter where the player moves within a fixed camera view, shoots enemies, and collects gold. Every 30 seconds, the player levels up and can choose a new upgrade.

---

## 🧩 Features
- Player movement and shooting mechanics  
- Enemy spawning and AI tracking  
- Gold drop and pickup system  
- Timed upgrade system (every 30 seconds)
- Modular C# codebase using `IEnumerator` and `LINQ`

---

## 🛠️ Technologies
- Unity 
- C#  
- VS Code  

---

## 🎮 Controls
| Key | Action |
|-----|---------|
| WASD | Move |
| Mous | Auto Shoot |
| Esc | Pause |

---

## 📸 Screenshots
![Gameplay Screenshot](https://example.com/screenshot.png)

---

## Code
```text
Assets/
 ┣ Scripts/
 ┃ ┣ Player/
 ┃ ┃ ┣ PlayerController.cs
 ┃ ┃ ┣ Shooting.cs
 ┃ ┃ ┣ PlayerStats.cs
 ┃ ┃ ┣ PlayerUpgrade.cs
 ┃ ┃ ┗ PlayerBound.cs
 ┃ ┣ Enemy/
 ┃ ┃ ┣ EnemyAI.cs
 ┃ ┃ ┣ Pig.cs
 ┃ ┃ ┗ EnemySpawn.cs
 ┃ ┣ Bullets/
 ┃ ┃ ┣ BaseBullet.cs
 ┃ ┃ ┣ WhiteBullet.cs
 ┃ ┃ ┣ BlueBullet.cs
 ┃ ┃ ┗ YellowBullet.cs
 ┣ ScriptObjects/
 ┃ ┣ EnemyAsset/
 ┃ ┃ ┣ EnemyDate.cs
 ┃ ┃ ┣ PigDate.Asset
 ┃ ┣ PlayerFormAsset/
 ┃ ┃ ┣ PlayerFormObject.cs
 ┃ ┃ ┣ BlueForm.Asset
 ┣ Prefabs/

 ┗ Scenes/
    ┗ MainScene.unity
```

---

## 🚀 How to Run

