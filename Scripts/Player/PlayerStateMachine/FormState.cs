// ==================================================
// Module: PlayerBound
// Purpose: subscribe event From FormUIMananger which create form change option to player;
// When Update, please update In FormAnimList And FormList
// Author: Shuheng
// Date: 2025/10/11
// Dependencies: None
// ==================================================

using System.Collections.Generic;
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

