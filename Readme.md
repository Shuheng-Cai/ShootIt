# Shoot It - Unity 2D Shooter Game 🎮

A top-down 2D shooter where the player moves within a fixed camera view, shoots enemies. Every 30 seconds, the player levels up and can choose a new upgrade.

---

## 🧩 Features
- Player movement and shooting mechanics  
- Enemy spawning and AI tracking    
- Timed upgrade system (every 30 seconds)

---

## 🛠️ Technologies
- Unity unity 6.2
- C#  9.0.305
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
- World Map and Region Map / how to? with A*? AND change the movement (Grid base Movement)
- Dice system
- Some other game

我的想法是把这个游戏拆成不同的小游戏，然后通过一个系统把这些小游戏串联起来。
初步想法是通过赚钱（不是现金）。然后谁能在100天以内赚最多的钱（当然是单机）。
然后可以通过职业系统 比如矿工？商人之类的，属性值？
然后在大地图上需要行动力（类似于博得之门那种）（主要想实现A星算法，实现在大地图上的行动）不同地块行动力损耗不同，不同职业每天行动力也会有区别。
小地图上不需要行动力。
自己找赚钱的方式。
这个串联的暂时不重要，我们可以实现一点小游戏。
比如，我现在做了一个射击小游戏，想模仿吸血鬼幸存者，但是可以把这个变成特殊事件，每次在大地图上行动就可能会发生这个特殊事件（确保玩家每天都会有事情做）。
然后我想的可以是几个方向：1.德州 2.消消乐
总而言之，我们就是尽量模仿其它成功的游戏。做成小游戏类型。
