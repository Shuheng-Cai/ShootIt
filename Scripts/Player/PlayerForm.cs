// ==================================================
// Module: PlayerBound
// Purpose: subscribe event From FormUIMananger which create form change option to player;
// Author: Shuheng
// Date: 2025/10/11
// Dependencies: None
// ==================================================

using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerForm : MonoBehaviour
{
    public FormState currentState;
    private StateFactory factory;
    private GameObject player;

    void Start()
    {
        player = transform.GameObject();
        currentState = new IdelState(player);
        factory = new StateFactory();
    }

    void Update()
    {
        currentState?.Update();
    }

    public void AddForm(FormState formChange)
    {
        
    }
    public void ChageForm(PlayerFormData playerFormObjects)
    {
        FormState formState = factory.Create(playerFormObjects.formName, player);
        transform.GetComponent<Shooting>().currentBulletData = playerFormObjects.baseBullet;
        if (formState != null)
        {
            currentState.Exit();
        }

        currentState = formState;
        currentState.Enter();
    }

}
