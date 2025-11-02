// ==================================================
// Module: WhiteBullet
// Purpose: second Bullet, spawn a lighting beside player
// Author: Shuheng
// Date: 2025/10/11
// Dependencies: BaseBullet
// ==================================================

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
