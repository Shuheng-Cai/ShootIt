// Module: WhiteBullet
// Purpose: Create GameOer text
// Invariants: 
// Performance: 
// Dependencies: 
// Known Tricky Cases: 

using UnityEngine;

public class WhiteBullet : BaseBullet
{
    protected override void Move()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
