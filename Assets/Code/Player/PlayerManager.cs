using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    public GameObject UImenu;
    public GameObject player;
    public GameObject[] playerPrefabs;
    public static Vector2 lastCheckPointPos = new Vector2(-3, 0);
    int charecterIndex;
    public static int numberOfCoins;
    public TextMeshProUGUI coinsText;
    private void Awake()
    {
        charecterIndex = PlayerPrefs.GetInt("SelectedCharacter", 0);
        numberOfCoins = PlayerPrefs.GetInt("NumberOfCoins", 0);
        player = Instantiate(playerPrefabs[charecterIndex], lastCheckPointPos, Quaternion.identity);
    }
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
        SceneManager.LoadScene("MenuMaps");
    }
    private void Update()
    {
        coinsText.text = "Coins: " + numberOfCoins;
    }
}
