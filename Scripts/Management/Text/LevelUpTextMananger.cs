using PixelBattleText;
using UnityEngine;
using System.Collections.Generic;

public class LevelUpTextMananger : MonoBehaviour
{
    public TextAnimation levelUp;
    private Vector3 textSpawnPosition = new Vector3(.5f,.65f, 0);
    void Start()
    {

    }
    public void LevelUpSbscribe(List<UpgradeOption> upgrades)
    {
        //Time.timeScale = 0f;
        PixelBattleTextController.DisplayText(
            "LEVEL UP",
            levelUp,
            textSpawnPosition
        );
    }
}
