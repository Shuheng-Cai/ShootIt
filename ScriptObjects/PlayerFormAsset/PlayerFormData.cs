using UnityEditor.Animations;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/PlayerFormData")]
public class PlayerFormData : ScriptableObject
{
    public AnimatorController formAnimController;
    public BulletData baseBullet;
    public string formName;
    public string UIName;
}
