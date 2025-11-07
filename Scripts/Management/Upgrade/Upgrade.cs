
// ==================================================
// Module: PlayerBound
// Purpose: Upgrade type; To realize Update, can use Update method
// Author: Shuheng
// Date: 2025/10/12
// Dependencies: None
// ==================================================

using UnityEngine;

public class UpgradeOption
{
    public string upgradeName;
    public string upgradeDescription;
    //public Sprite upgradeIcon;
    public UpgradeType upgradeType;
    public float upgradeValue;
    public FormState upgradeForm;

    public void Upgrade(string name, string description, UpgradeType type, float val)
    {
        upgradeName = name;
        upgradeDescription = description;
        //upgradeIcon = icon;
        upgradeType = type;
        upgradeValue = val;
    }

    public void Upgrade(string name, string description, UpgradeType type)
    {
        upgradeName = name;
        upgradeDescription = description;
        //upgradeIcon = icon;
        upgradeType = type;
    }
}

public enum UpgradeType
{
    FireRate, Damage, MoveSpeed, Form, Heal
}

public enum FormType
{
    yellowState, blueState, greenState
}
