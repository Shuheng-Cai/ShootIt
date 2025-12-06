// ==================================================
// Module: Shooting
// Purpose: the UI of upgrade/ has event: onUpgradeSelected
// Author: Shuheng
// Date: 2025/10/11
// Dependencies: Upgrade Class/ UpgradeEvent, which will invoke upgradeevnet and call this
// ==================================================

using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.Events;
using TMPro;

public class UpgradeUIManager : MonoBehaviour
{
    [SerializeField] private GameObject upgradePanel;
    [SerializeField] private Button upgradeButtonPrefab;
    [SerializeField] private Transform buttonContainer;

    private PlayerUpgrade playerUpgrade;
    private List<Button> currentButtons = new List<Button>();

    public UnityEvent<UpgradeOption> onUpgradeSelected = new UnityEvent<UpgradeOption>();
    public GameObject player;

    void Awake()
    {
        upgradePanel = transform.gameObject;
        upgradePanel.SetActive(false);
        onUpgradeSelected.AddListener(player.GetComponent<PlayerUpgrade>().Upgrade);
        onUpgradeSelected.AddListener(transform.GetComponent<FormUIManager>().Subscribe);
    }

    public void ShowUpgradeOptions(List<UpgradeOption> upgrades)
    {
        upgradePanel.SetActive(true);
        Time.timeScale = 0f; // stop game

        // clear old button
        foreach (var btn in currentButtons)
            Destroy(btn.gameObject);
        currentButtons.Clear();

        // spawn new button
        foreach (var upgrade in RandomThreeUpgrades(upgrades))
        {
            Button btn = Instantiate(upgradeButtonPrefab, buttonContainer);
            btn.GetComponentInChildren<TextMeshProUGUI>().text = upgrade.upgradeName;
            btn.onClick.AddListener(() => OnUpgradeSelect(upgrade));
            currentButtons.Add(btn);
        }
    }

    private void OnUpgradeSelect(UpgradeOption upgrade)
    {
        CloseUpgradeUI();
        onUpgradeSelected.Invoke(upgrade);
    }

    private void CloseUpgradeUI()
    {
        upgradePanel.SetActive(false);
        Time.timeScale = 1f; // 恢复游戏
        foreach (var btn in currentButtons)
            Destroy(btn.gameObject);
        currentButtons.Clear();
    }

    // To select three Upgrades to adopt
    private List<UpgradeOption> RandomThreeUpgrades(List<UpgradeOption> upgrades)
    {
        List<UpgradeOption> selected = new List<UpgradeOption>();
        HashSet<int> usedIndexes = new HashSet<int>();

        // random Pick three Update
        while (selected.Count < 3 && selected.Count < upgrades.Count)
        {
            int rand = Random.Range(0, upgrades.Count);
            if (usedIndexes.Add(rand))
            {
                selected.Add(upgrades[rand]);
            }
        }

        return selected; 
    }
}
