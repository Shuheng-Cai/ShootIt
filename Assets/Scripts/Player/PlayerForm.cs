// Module: PlayerForm
// Purpose: Control the form of Player. Put the bullet to the PlayerFormData.
// Invariants: factory, player
// Performance: 
// Dependencies: StateFactory; PlayerFormData;
// Known Tricky Cases: changeForm is subscribe in the FormUIManger.cs and get the PlayerFormData to create in the factory
//                     Then, enter, so you should Reigister in StateFactory this type.

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
