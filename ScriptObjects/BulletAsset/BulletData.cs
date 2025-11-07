// Module: BulletData
// Purpose: Create Bullet ScriptableObject
// Invariants: 
// Performance: 
// Dependencies: 
// Known Tricky Cases:
using UnityEngine;

[CreateAssetMenu(menuName = "Game/BulletData")]
public class BulletData : ScriptableObject
{
    public int lifeTime;
    public GameObject bulletPrefeb;
    public float speed;
    public bool canPenetrate;
}
