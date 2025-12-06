// Module: PlayerFormData
// Purpose: Store the data of PlayerForm.
// Invariants: 
// Performance: 
// Dependencies: PixelBattleTextController
// Known Tricky Cases: Create Canvas, Create a empty rect transform and use this and add PixelBattleTextController

using UnityEngine;

[CreateAssetMenu(menuName = "Game/PlayerFormData")]
public class PlayerFormData : ScriptableObject
{
    public RuntimeAnimatorController formAnimController;

    public BulletData baseBullet;
    public string formName;
    public string UIName;
}
