using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_bar : MonoBehaviour
{
    [SerializeField] private string sceneHome;
    [SerializeField] private string sceneSpawn;
    [SerializeField] private string Continue;
    [SerializeField] private GameObject dieBar;
    [SerializeField] private Animator animator;

    [SerializeField] private bool home;
    [SerializeField] private bool spawn;
    [SerializeField] private bool ConTinue;
    private void EnableDieBar()
    {
        //if ()
        //{
        //    dieBar.SetActive(true);
        //    Time.timeScale = 0;
        //}
    }
    private void ClickButton()
    {
        if (home)
        {
            SceneManager.LoadScene(sceneHome);
            Time.timeScale = 1;
        }
        if (spawn)
        {
            SceneManager.LoadScene(sceneSpawn);
            Time.timeScale = 1;
        }
    }
    public void HomeButton()
    {
        home = true;
    }
    public void ReSpwan()
    {
        spawn = true;
    }

    private void Update()
    {
    }
}
