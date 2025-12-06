# Shoot It - Unity 2D Shooter Game 🎮

A top-down 2D shooter where the player moves within a fixed camera view, shoots enemies. Every 30 seconds, the player levels up and can choose a new upgrade.

---

## 🧩 Features
- Player movement and shooting mechanics  
- Enemy spawning and AI tracking    
- Timed upgrade system (every 30 seconds)

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
| Mous | Control Shooting and movement Direction |

---

## Code
```text
Assets/
 ┣ Scripts/
 ┃ ┣ Player/  
 ┃ ┃ ┣ PlayerStateMachine/ StateFactory   
 ┃ ┃ ┣ PlayerController.cs
 ┃ ┃ ┣ Shooting.cs                  
 ┃ ┃ ┣ PlayerStats.cs
 ┃ ┃ ┣ PlayerUpgrade.cs
 ┃ ┃ ┗ PlayerBound.cs
 ┃ ┣ Enemy/
 ┃ ┃ ┣ Enenmy.cs
 ┃ ┃ ┣ Pig/  
 ┃ ┃ ┣ Bee/Bee BeeBullet
 ┃ ┃ ┗ EnemySpawn.cs
 ┃ ┣ Bullets/
 ┃ ┃ ┣ BaseBullet.cs
 ┃ ┃ ┣ WhiteBullet.cs
 ┃ ┃ ┣ BlueBullet.cs
 ┃ ┃ ┗ YellowBullet.cs
 ┣ ScriptObjects/
 ┃ ┣ BulletAsset/
 ┃ ┣ ┣ BulletDate.cs
 ┃ ┣ ┣ BlueBullet.Asset
 ┃ ┣ ┣ WhiteBullet.Asset
 ┃ ┣ ┣ YellowBullet.Asset
 ┃ ┣ EnemyAsset/
 ┃ ┃ ┣ BeeDate.Asset
 ┃ ┃ ┣ PigDate.Asset
 ┃ ┣ PlayerFormAsset/
 ┃ ┃ ┣ PlayerFormObject.cs
 ┃ ┃ ┣ BlueForm.Asset
 ┃ ┣ ┣ YellowForm.Asset
 ┣ Prefabs/
 ┗ Scenes/
    ┣ MainMenu.unity
    ┣ GamePlaye
    ┣ GameOver
```

---

## 🚀 How to Run

---

# Future Work 👷
- More Enemys: Ghost and Bunny.
- Gold and store system.
- Achievement and record the data
