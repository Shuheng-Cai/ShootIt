// Module: MainMenuTextController
// Purpose: Create GameOer text
// Invariants: 
// Performance: 
// Dependencies: PixelBattleTextController
// Known Tricky Cases: Create Canvas, Create a empty rect transform and use this and add PixelBattleTextController

using PixelBattleText;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuTextManager : MonoBehaviour
{
    public TextAnimation mainMenu;
    private Vector3 textSpawnPosition = new Vector3(0.5f, 0.9f, 0);
    void Start()
    {
        PixelBattleTextController.DisplayText(
            "SHOOIT",
            mainMenu,
            textSpawnPosition
        );
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeToGame()
    {
        SceneManager.LoadScene("GamePlay");
    }
}
