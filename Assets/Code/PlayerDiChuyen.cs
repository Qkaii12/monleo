using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDiChuyen : MonoBehaviour
{
    PlayerControl control;
    float direction = 0;
    public float speed = 10f;
    public float jumpForce = 10f;
    public Rigidbody2D rg2;
    public Animator animator;
    bool isFacingRight = true;
    public bool isGrounded;
    public Transform Checkground;
    public LayerMask groundLayer;
    private const string IsJumpingParaName = "jump";
    private void Awake()
    {
        control = new PlayerControl();
        control.Enable();

        control.Map_1.Move.performed += ctx =>
        {
            direction = ctx.ReadValue<float>();
        };
        control.Map_1.Jump.performed += ctx => Jump();
    }
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(Checkground.position, 0.1f, groundLayer);
        rg2.velocity = new Vector2(direction * speed * Time.deltaTime, rg2.velocity.y);
        animator.SetFloat("walk", Mathf.Abs(direction));

        if (isFacingRight && direction < 0 || isFacingRight && direction > 0)
            Flip();
    }
    void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }

    void Jump()
    {
        if (isGrounded) 
        { 
            rg2.velocity = new Vector2(rg2.velocity.x, jumpForce);
            animator.SetBool(IsJumpingParaName, true);
            AudioManager.instance.Play("Jump");
        }
        else
        {
            animator.SetBool(IsJumpingParaName, false);
        }
    }
}
