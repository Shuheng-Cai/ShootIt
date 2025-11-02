// ==================================================
// Module: BlueState
// Purpose: canPenetrate
// Author: Shuheng
// Date: 2025/10/11
// Dependencies: None
// ==================================================

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
