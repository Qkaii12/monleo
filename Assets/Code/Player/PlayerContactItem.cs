using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContactItem : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    private int score = 0;
    private bool hasFirePower = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score: " + score);
    }
    public void Grow()
    {
        transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
    }
    public void EnableFirePower()
    {
        hasFirePower = true;
        Debug.Log("Fire power enabled");
    }
}

