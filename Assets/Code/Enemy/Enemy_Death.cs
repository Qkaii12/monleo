using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Death : MonoBehaviour
{
    public float moveSpeed = 2f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // Kiểm tra xem nhân vật có nhảy lên đầu quái vật hay không
            if (collision.contacts[0].normal.y < -0.5)
            {
                Destroy(gameObject); // Tiêu diệt quái vật
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10f), ForceMode2D.Impulse); // Tăng lực nhảy lên cho nhân vật
            }
            else
            {
                Debug.Log("Player hit by enemy!");
                collision.gameObject.GetComponent<PlayerDeath>().Die(); // Gọi hàm Die() của nhân vật
            }
        }
        
    }
}
