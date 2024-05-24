using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectCoin : MonoBehaviour
{
    public static int numberOfCoins;
    public TextMeshProUGUI coinsText;

    private void Awake()
    {
        numberOfCoins = PlayerPrefs.GetInt("NumberOfCoins", 0);
    }
    private void Update()
    {
        coinsText.text = "Coins: " + numberOfCoins;
    }
}
