using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckButton : MonoBehaviour
{
    public void PointerDownReplay()
    {
        SceneManager.LoadScene("Map_1");
        Time.timeScale = 1f;
    }
}
