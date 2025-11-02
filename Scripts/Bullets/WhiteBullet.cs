// ==================================================
// Module: WhiteBullet
// Purpose: the basic bullet lowest damage
// Author: Shuheng
// Date: 2025/10/11
// Dependencies: BaseBullet
// ==================================================

using UnityEngine;

public class WhiteBullet : BaseBullet
{
    protected override void Move()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
