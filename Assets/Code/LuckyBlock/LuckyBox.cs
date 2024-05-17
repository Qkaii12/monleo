using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class LuckyBox : MonoBehaviour
{
    public Sprite emtyBoxSprite;
    public GameObject NamTo;
    public GameObject Coin;
    public GameObject NamDOc;
    public GameObject[] items;
    private bool isUsed = false;
    private void Start()
    {
        items = new GameObject[] { NamDOc, Coin, NamTo};
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isUsed && collision.collider.CompareTag("Player"))
        {
            ContactPoint2D[] contacts = collision.contacts;
            foreach (ContactPoint2D contact in contacts)
            {
                if (contact.normal.y > 0.5f)
                {
                    SpawnItem();
                    GetComponent<SpriteRenderer>().sprite = emtyBoxSprite;
                    isUsed = true;
                    break;
                }
            }
        }
    }

    private void SpawnItem()
    {
        if (items.Length > 0)
        {
            int randomIndex = Random.Range(0, items.Length);
            Instantiate(items[randomIndex], transform.position + Vector3.up, Quaternion.identity);
        }
    }
}
