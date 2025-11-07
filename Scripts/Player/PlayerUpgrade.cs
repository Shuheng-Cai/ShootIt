// Module: PlayerUpdate
// Purpose: Control player to update;
// Invariants: 
// Performance: 
// Dependencies: PlayerController, PlayerState
// Known Tricky Cases: 

using UnityEngine;
using UnityEngine.Events;

public class PlayerUpgrade : MonoBehaviour
{
    PlayerController playerController;
    PlayerState playerState;
    PlayerForm playerForm;
    public UnityEvent<FormState> unityEventForm = new UnityEvent<FormState>();

    void Start()
    {
        playerController = transform.GetComponent<PlayerController>();
        playerState = transform.GetComponent<PlayerState>();
        playerForm = transform.GetComponent<PlayerForm>();
    }

    public void Upgrade(UpgradeOption upgrade)
    {
        if (upgrade.upgradeType == UpgradeType.Damage)
        {
           playerState.shootDamage = playerState.shootDamage * upgrade.upgradeValue;
        }

        if (upgrade.upgradeType == UpgradeType.FireRate)
        {
            playerState.fireRate += upgrade.upgradeValue;
        }

        if (upgrade.upgradeType == UpgradeType.MoveSpeed)
        {
            playerController.moveSpeed += upgrade.upgradeValue;
        }

        if (upgrade.upgradeType == UpgradeType.Heal)
        {
            playerState.currentLife += upgrade.upgradeValue;
            playerState.life += upgrade.upgradeValue;
        }
    }
}
