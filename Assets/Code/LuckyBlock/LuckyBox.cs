using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class LuckyBox : MonoBehaviour
{
    public Sprite emtyBoxSprite;
    public GameObject[] items;
    private bool isUsed = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(!isUsed && collision.collider.CompareTag("Player"))
        {
            SpawnItem();
            GetComponent<SpriteRenderer>().sprite = emtyBoxSprite;
            isUsed = true;
        }
    }

    private void SpawnItem()
    {
        if(items.Length > 0)
        {
            int randomIndex = Random.Range(0, items.Length);
            GameObject item = Instantiate(items[randomIndex], transform.position + Vector3.up, Quaternion.identity);
        }
    }
}
