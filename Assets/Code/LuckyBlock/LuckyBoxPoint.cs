using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuckyBoxPoint : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private const string isTouch = "block";
    public bool Block;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Box();
        }
    }
    private void Box()
    {
        animator.SetTrigger(isTouch);
        GetComponent<BoxCollider2D>().enabled = true;
        GetComponent<CircleCollider2D>().enabled = false;
        Block = true;
    }
    private void Update()
    {
        if (Block == true)
        {
            Box();
        }
    }
}
