using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    private const string isDieParaname = "die";
    [SerializeField] private Animator animator;
    public bool isDieAnim = false;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.CompareTag("Enemy"))
    //    {
    //        Die();
    //    }
    //}
    //private void Die()
    //{
    //    animator.SetBool(IsDeathParaName, true);


    //    EndGame();
    //}

    //private void EndGame()
    //{
    //    Time.timeScale = 0f;
    //}
    //private void Update()
    //{
    //    Die();
    //}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Death();
        }
    }
    private void Death()
    {
        animator.SetTrigger(isDieParaname);
        isDieAnim = true;
    }
    private void Update()
    {
        if (isDieAnim && !animator.GetCurrentAnimatorStateInfo(0).IsName("DieAnimation"))
        {
            Death();
            Debug.Log("Chết xong!");
            // Ví dụ: Hiển thị màn hình Game Over
            // GameOverScreen.SetActive(true);
        }
    }

}
