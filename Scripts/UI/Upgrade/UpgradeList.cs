// ==================================================
// Module: UpgradeList (In UpgradeUI object)
// Purpose: Upgrade List (how to upgrade). 
// Author: Shuheng
// Date: 2025/10/15
// Dependencies: Upgrade Class/ UpgradeEvent, which will invoke upgradeevnet and call this
// ==================================================

using UnityEngine;
using System.Collections.Generic;

public class UpgradeList : MonoBehaviour
{
    public List<UpgradeOption> allUpgrades = new List<UpgradeOption>();
    public GameObject player;

    void Start()
    {
        //Find player?
        player = GameObject.FindWithTag("Player");
        UpgradeOption upgrade1 = new UpgradeOption();
        upgrade1.Upgrade(
            "RAPID FIRE",
            "Increase your fire rate by 20%",
            UpgradeType.FireRate,
            0.8f
        );

        UpgradeOption upgrade2 = new UpgradeOption();
        upgrade2.Upgrade(
            "DAMAGE INCREASE",
            "Increase your damage 5",
            UpgradeType.Damage,
            5f
        );


        UpgradeOption upgrade3 = new UpgradeOption();
        upgrade3.Upgrade(
            "SPEED UP",
            "Increase your movement speed by 5",
            UpgradeType.MoveSpeed,
            5f
        );

        //This one will be update Later for more state and indenpent
        UpgradeOption upgrade4 = new UpgradeOption();
        upgrade4.Upgrade(
            "CHANGE FORM",
            "Choose a Form Now!",
            UpgradeType.Form
        );

        UpgradeOption upgrade5 = new UpgradeOption();
        upgrade5.Upgrade(
            "HEALING AURO",
            "Increase 20 of your Max HP",
            UpgradeType.Heal,
            20f
        );

        allUpgrades.Add(upgrade1);
        allUpgrades.Add(upgrade2);
        allUpgrades.Add(upgrade3);
        allUpgrades.Add(upgrade4);
        allUpgrades.Add(upgrade5);
    }
}
