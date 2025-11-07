
using UnityEngine;

[CreateAssetMenu(menuName = "Game/PlayerFormData")]
public class PlayerFormData : ScriptableObject
{
    public RuntimeAnimatorController formAnimController;

    public BulletData baseBullet;
    public string formName;
    public string UIName;
}
