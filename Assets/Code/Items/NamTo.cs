using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NamTo : MonoBehaviour
{
    public float speed = 2f;

    private void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.CompareTag("Player"))
        {
            PlayerContactItem player = collider2D.GetComponent<PlayerContactItem>();
            if(player != null)
            {
                player.Grow();
            }

            Destroy(gameObject);
        }
    }
}
