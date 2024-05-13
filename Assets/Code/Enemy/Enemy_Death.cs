using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Death : MonoBehaviour
{
    public bool isDie = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PlayerDick"))
        {
            Death();
        }
    }
    private void Death()
    {
        Destroy(gameObject);
        isDie = true;
    }
    private void Update()
    {
        if(isDie == true)
        {
            Death();
        }
    }
}
