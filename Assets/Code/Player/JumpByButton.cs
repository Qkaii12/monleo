using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpByButton : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private Animator animator;
    private bool jump;
    public float jumpForce = 10f;
    private const string IsJumpingParaName = "jump";
    public bool ground;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    public void PointerDownJump()
    {
        jump = true;
    }

    public void PointerUpJump()
    {
        jump = false;
    }

    void Update()
    {
        if (jump)
        {
            Jump();
        }
    }

    private void Jump()
    {
        AudioManager.instance.Play("Jump");
        animator.SetBool(IsJumpingParaName, true);
        if (ground)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            ground = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            animator.SetBool(IsJumpingParaName, false);
            ground = true;
        }
    }
}
