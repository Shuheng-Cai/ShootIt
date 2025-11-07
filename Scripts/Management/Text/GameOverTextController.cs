// Module: GameOverTextController
// Purpose: Create GameOer text
// Invariants: 
// Performance: 
// Dependencies: PixelBattleTextController
// Known Tricky Cases: Create Canvas, Create a empty rect transform and use this and add PixelBattleTextController

using UnityEngine;
using PixelBattleText;
using System.Collections;

public class GameOverTextController : MonoBehaviour
{
    public TextAnimation gameOver;
    private Vector3 textSpawnPosition = new Vector3(0.5f, 0.65f, 0);

    void Start()
    {
        GameOverSbscribe();
        StartCoroutine(ChangeToMainMenu());
    }

    public void GameOverSbscribe()
    {
        PixelBattleTextController.DisplayText(
            "GAME OVER",
            gameOver,
            textSpawnPosition
        );
        // Time.timeScale = 0f;
    }

    IEnumerator ChangeToMainMenu()
    {
        yield return new WaitForSeconds(3);
        SceneChangeManager.ChangeToMainMenu();
    }
}
