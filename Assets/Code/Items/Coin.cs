using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int value = 1;
    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.CompareTag("Player"))
        {
            PlayerContactItem player = collider2D.GetComponent<PlayerContactItem>();
            if(player != null)
            {
                CollectCoin.numberOfCoins++;
                AudioManager.instance.Play("Coins");
                PlayerPrefs.GetInt("NumberOfCoins", CollectCoin.numberOfCoins);
                player.AddScore(value);
            }

            Destroy(gameObject);
        }
    }
}
