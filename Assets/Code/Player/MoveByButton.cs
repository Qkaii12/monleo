using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoveByButton : MonoBehaviour
{
    PlayerControl controls;
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private Animator anim;
    private SpriteRenderer spr;
    private float direction = 0f;
    [SerializeField]
    private LayerMask groundLayers;
    [SerializeField]
    private float moveSpeed = 7f;
    [SerializeField]
    private float jumpSpeed = 15f;

    private const string IsRunningParaName = "walk";
    private const string IsJumpingParaName = "jump";

    private void Awake()
    {
        controls = new PlayerControl();
        controls.Enable();
        controls.Map_1.Move.performed += ctx =>
        {
            direction = ctx.ReadValue<float>();
        };

        controls.Map_1.Jump.performed += ctx => Jump();
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();
        spr = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        direction = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(direction * moveSpeed * Time.deltaTime, rb.velocity.y);

        if(Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }

        if(direction > 0f)
        {
            anim.SetBool(IsRunningParaName, true);
            spr.flipX = false;
        }
        else if(direction < 0f)
        {
            anim.SetBool(IsRunningParaName, true);
            spr.flipX = true;
        }
        else
        {
            anim.SetBool(IsRunningParaName, false);
        }
        if(rb.velocity.y > .1f)
        {
            anim.SetBool(IsJumpingParaName, true);
        }
    }
    void Jump()
    {
        if (IsGrounded())
        {
            AudioManager.instance.Play("Jump");
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }
    }

   bool IsGrounded()
   {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, groundLayers);
   }
    private void OnEnable()
    {
        controls.Enable();
    }
    private void OnDisable()
    {
        controls.Disable();
    }
}
