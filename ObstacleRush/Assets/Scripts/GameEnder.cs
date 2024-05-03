using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnder : MonoBehaviour
{
    // Function to restart the game (load scene)
    public void RestartGame()
    {
        SceneManager.LoadScene("Loading Screen");

        Time.timeScale = 1f;
    }

    // Function to quit the game
    public void QuitGame()
    {
        // Quit the application
        Application.Quit();
    }
}
