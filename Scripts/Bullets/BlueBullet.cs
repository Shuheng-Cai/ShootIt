// Module: BlueBullet
// Purpose: 
// Invariants: 
// Performance: 
// Dependencies:
// Known Tricky Cases:

using UnityEngine;

public class BlueBullet : BaseBullet
{
    protected override void Start()
    {
        
    }
    protected override void Move()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
