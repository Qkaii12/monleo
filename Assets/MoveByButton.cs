using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByButton : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private Animator animator;
    private const string IsRunningParaName = "walk";
    private bool moveLeft;
    private bool moveRight;
    private float horizontalMove;
    public float speed = 5;
    private bool facingRight = true;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        moveLeft = false;
        moveRight = false;
    }

    public void PointerDownLeft()
    {
        moveLeft = true;
        FlipCharacter(false);
    }
    public void PointerDownRight()
    {
        moveRight = true;
        FlipCharacter(true);
    }
    public void PointerUpRight()
    {
        moveRight = false;
    }
    public void PointerUpLeft()
    {
        moveLeft = false;
    }

    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        if (moveLeft)
        {
            horizontalMove = -speed;
            animator.SetBool(IsRunningParaName, true);
        }
        else if (moveRight)
        {
            horizontalMove = speed;
            animator.SetBool(IsRunningParaName, true);
        }
        else
        {
            horizontalMove = 0;
            animator.SetBool(IsRunningParaName, false);
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalMove, rb.velocity.y);
    }
    private void FlipCharacter(bool faceRight)
    {
        if (faceRight && !facingRight || !faceRight && facingRight)
        {
            facingRight = !facingRight;
            Vector3 scale = transform.localScale;
            scale.x *= -1;
            transform.localScale = scale;
        }
    }
}
