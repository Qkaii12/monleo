using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private Animator animator;
    private const string IsDeathParaName = "die";
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy")) // Kiểm tra xem Collider đó có phải là vật thể mà người chơi chết khi va chạm không
        {
            Die(); // Gọi hàm Die() để xử lý việc người chơi chết
        }
    }
    private void Die()
    {
        // Đây là nơi bạn có thể thực hiện các hành động khi người chơi chết,
        // như hiển thị thông báo, hoặc thực hiện các animation, âm thanh, v.v.
        
        animator.SetBool(IsDeathParaName, true);

    
        EndGame();
    }

    private void EndGame()
    {
        // Đây là nơi bạn thực hiện các hành động để kết thúc trò chơi,
        // như hiển thị điểm số, chuyển đến màn hình kết thúc, v.v.

        // Ví dụ: Dừng trò chơi
        Time.timeScale = 0f;
    }
}
