using UnityEngine;

[CreateAssetMenu(menuName = "Game/BulletData")]
public class BulletData : ScriptableObject
{
    public int lifeTime;
    public GameObject bulletPrefeb;
    public float speed;
    public bool canPenetrate;
}
