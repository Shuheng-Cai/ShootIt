// ==================================================
// Module: FormUIManager
// Purpose: Change Form
// Author: Shuheng
// Date: 2025/10/11
// Dependencies: Upgrade Class/ Now only Depend on PlayerFormObjects(ScriptObject!) only need to update this
// ==================================================

using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.Events;
using TMPro;

public class FormUIManager : MonoBehaviour
{
    [SerializeField] private GameObject upgradePanel;
    [SerializeField] private Button upgradeButtonPrefab;
    [SerializeField] private Transform buttonContainer;
    private List<Button> currentButtons = new List<Button>();

    public UnityEvent<PlayerFormData> onUpgradeSelected = new UnityEvent<PlayerFormData>();
    public GameObject player;
    public List<PlayerFormData> playerFormData;

    void Awake()
    {
        upgradePanel = transform.gameObject;
        onUpgradeSelected.AddListener(player.GetComponent<PlayerForm>().ChageForm);
        onUpgradeSelected.AddListener(player.GetComponent<FormAnimList>().ChangeFormAnim);
    }

    public void ShowUpgradeOptions(List<PlayerFormData> forms)
    {
        upgradePanel.SetActive(true);
        Time.timeScale = 0f; // stop game

        // clear old button
        foreach (var btn in currentButtons)
            Destroy(btn.gameObject);
        currentButtons.Clear();

        // spawn new button
        foreach (var upgrade in RandomThreeUpgrades(forms))
        {
            Button btn = Instantiate(upgradeButtonPrefab, buttonContainer);
            btn.GetComponentInChildren<TextMeshProUGUI>().text = upgrade.UIName;
            btn.onClick.AddListener(() => OnUpgradeSelect(upgrade));
            currentButtons.Add(btn);
        }
    }

    private void OnUpgradeSelect(PlayerFormData upgrade)
    {
        onUpgradeSelected.Invoke(upgrade);
        CloseUpgradeUI();
        foreach (var btn in currentButtons)
            Destroy(btn.gameObject);
        currentButtons.Clear();
    }

    private void CloseUpgradeUI()
    {
        upgradePanel.SetActive(false);
        Time.timeScale = 1f; // 恢复游戏
    }

    // To select three Upgrades to adopt
    private List<PlayerFormData> RandomThreeUpgrades(List<PlayerFormData> upgrades)
    {
        List<PlayerFormData> selected = new List<PlayerFormData>();
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
    
    public void Subscribe(UpgradeOption upgradeOption)
    {
        if (upgradeOption.upgradeType == UpgradeType.Form)
        {
            ShowUpgradeOptions(playerFormData);
        }
    }
}
