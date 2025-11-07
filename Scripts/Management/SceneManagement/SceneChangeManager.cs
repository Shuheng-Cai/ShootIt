// Module: SceneChangeMananger
// Purpose: Control Scene to change
// Invariants: 
// Performance: 
// Dependencies: 
// Known Tricky Cases: 

using UnityEngine.SceneManagement;

public static class SceneChangeManager
{
    public static void ChangeToGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    public static void ChangeToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
