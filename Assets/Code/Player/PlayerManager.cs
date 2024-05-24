using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public GameObject UImenu;
    public void PauseGame()
    {
        Time.timeScale = 0;
        UImenu.SetActive(true);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
        UImenu.SetActive(false);
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
