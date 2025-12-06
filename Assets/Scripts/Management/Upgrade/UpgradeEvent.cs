// Module: GameOverTextController
// Purpose: To control upgrade, after an upgradeInterval.
// Invariants: 
// Performance: There is a upgradeEvent list. 
// Dependencies: Upgrade; UpgradeList
// Known Tricky Cases: To instantialize Upgrade 

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UpgradeEvent : MonoBehaviour
{
    UnityEvent<List<UpgradeOption>> upgradeEvent;
    public GameObject UI;
    public float upgradeInterval = 5f;
    private float timer = 0f;
    public UpgradeList upgradeList;
    public GameObject textMananger;

    void Start()
    {
        if (upgradeEvent == null)
            upgradeEvent = new UnityEvent<List<UpgradeOption>>();

        upgradeEvent.AddListener(textMananger.GetComponent<LevelUpTextMananger>().LevelUpSbscribe);
        upgradeEvent.AddListener(UI.GetComponent<UpgradeUIManager>().ShowUpgradeOptions);

        upgradeList = transform.GetComponent<UpgradeList>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= upgradeInterval)
        {
            timer = 0f;
            upgradeEvent.Invoke(upgradeList.allUpgrades);
        }
    }
}
