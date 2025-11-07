// Module: YelloweBullet
// Purpose: Stay Still
// Invariants: 
// Performance: 
// Dependencies:
// Known Tricky Cases:

using UnityEngine;

public class YellowBullet : BaseBullet
{
    protected override void Start()
    {
        Destroy(gameObject, lifeTime);
    }
    protected override void Move()
    {
        
    }
}
