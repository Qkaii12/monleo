using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    private const string isDieParaname = "die";
    [SerializeField] private Animator animator;
    private Rigidbody2D rb;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
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
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Enemy"))
    //    {
    //        Death();
    //    }
    //}
    //private void Death()
    //{
    //    animator.SetTrigger(isDieParaname);
    //    isDieAnim = true;
    //}
    //private void Update()
    //{
    //    if (isDieAnim && !animator.GetCurrentAnimatorStateInfo(0).IsName("DieAnimation"))
    //    {
    //        Death();
    //        Debug.Log("Chết xong!");
    //        // Ví dụ: Hiển thị màn hình Game Over
    //        //object p = GameOverScreen.SetActive(true);
    //    }
    //}}
    public void Die()
    {
        // Xử lý cái chết của nhân vật, ví dụ tải lại cảnh hiện tại
        //Time.timeScale = 0f;
        AudioManager.instance.Play("GameOver");
        animator.SetTrigger(isDieParaname);
        rb.velocity = new Vector2(0, 8f);
        GetComponent<Collider2D>().enabled = false;
        Invoke("LoadGameOverScene", 1f);
    }
    private void LoadGameOverScene()
    {
        Time.timeScale = 0f;
        SceneManager.LoadScene("GameOverScenes");
    }
}
