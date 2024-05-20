using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public GameObject pauseMenuScenes;
    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {

    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
