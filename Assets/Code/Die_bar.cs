using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Die_bar : MonoBehaviour
{
    [SerializeField] private string sceneHome;
    [SerializeField] private string sceneSpawn;
    [SerializeField] private GameObject dieBar;
    [SerializeField] private PlayerDeath death;
    [SerializeField] private Animator animator;

    [SerializeField] private bool home;
    [SerializeField] private bool spawn;
    private void EnableDieBar()
    {
        if (death.isDieAnim && ! animator.GetCurrentAnimatorStateInfo(0).IsName("DieAnimation"))
        {
            dieBar.SetActive(true);
            Time.timeScale = 0;
        }
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
        EnableDieBar();
        ClickButton();
    }
}
