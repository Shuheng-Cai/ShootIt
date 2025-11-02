// ==================================================
// Module: Yellow State
// Purpose: flash bullet/ move 
// Author: Shuheng
// Date: 2025/10/11
// Dependencies: None
// ==================================================

using UnityEngine;

public class YellowState : FormState
{
    public YellowState(GameObject player) : base(player)
    {
    }

    public override void Enter()
    {
        formName = "YellowState";
        player.GetComponent<Shooting>().bulletType = 1;
    }

    public override void Exit()
    {
        
    }

    public override void Update()
    {
        
    }
}
