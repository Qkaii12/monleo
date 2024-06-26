using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDiChuyen : MonoBehaviour
{
    PlayerControl control;
    float direction = 0;
    public float speed = 7;
    public Rigidbody2D rg2;
    private void Awake()
    {
        control = new PlayerControl();
        control.Enable();

        control.Map_1.Move.performed += ctx =>
        {
            direction = ctx.ReadValue<float>();
        };
    }
    void Update()
    {
        rg2.velocity = new Vector2(direction * speed * Time.deltaTime, rg2.velocity.y);
    }
}
