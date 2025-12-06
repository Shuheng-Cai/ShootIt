// Module: YellowState
// Purpose: YellowState, spawn a light under player.
// Invariants: 
// Performance: 
// Dependencies: FormState; StateFactory
// Known Tricky Cases: 

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
