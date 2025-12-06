// Module: BlueState
// Purpose: Blue form, the bullet can penetrate enemy
// Invariants: 
// Performance: 
// Dependencies: FormState, BlueBullet

using UnityEngine;

public class BlueState : FormState
{
    public BlueState(GameObject player) : base(player)
    {
    }
    public override void Enter()
    {
        player.GetComponent<Shooting>().bulletType = 2;
        formName = "BlueState";
    }

    public override void Exit()
    {
        
    }

    public override void Update()
    {
        
    }
}
