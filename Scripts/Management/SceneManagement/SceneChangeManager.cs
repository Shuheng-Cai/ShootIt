using UnityEngine;
using System;
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
