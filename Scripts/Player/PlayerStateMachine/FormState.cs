// Module: FormState
// Purpose: the father class of Form
// Invariants: 
// Performance: Enter; Update; Exit.
// Dependencies: 
// Known Tricky Cases: can get player when create.


using UnityEngine;

public abstract class FormState
{
    protected GameObject player;
    public string formName;

    public FormState(GameObject player)
    {
        this.player = player;
    }
    public abstract void Enter();
    public abstract void Update();
    public abstract void Exit();
}

