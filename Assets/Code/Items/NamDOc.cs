using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NamDOc : MonoBehaviour
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
                PlayerDeath player = collider2D.GetComponent<PlayerDeath>();
                if (player != null)
                {
                    player.Die();
                }

                Destroy(gameObject);
            }
        }
}
