// Module: Upgrade Class
// Purpose: Define UpgradeOption
// Invariants: 
// Performance: 
// Dependencies: 
// Known Tricky Cases: May be can be ScriptableObject

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
