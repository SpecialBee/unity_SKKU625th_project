using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour
{
    public float jumpForce = 5f; // 점프 힘
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump")) // Jump 키(예: 스페이스바)를 누를 때
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}

