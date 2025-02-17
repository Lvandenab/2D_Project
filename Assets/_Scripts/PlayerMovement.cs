using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpForce = 12.0f;
    public BoxCollider2D groundCollider;
    public SpriteRenderer sr;
    public Animator animator;

    private Rigidbody2D rb;
    public const float gravity = 2.5f;

    // Improvements to consider:
    // - Double jump
    // - Easing into movement (accelerating more slowly)

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = gravity;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            sr.flipX = true;
            if (IsGrounded())
            {
                animator.Play("Trueplayerwalk");
            }

        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            sr.flipX=false;
            if (IsGrounded())
            {
                animator.Play("Trueplayerwalk");
            }
            
        }
        else
        {
            animator.Play("Idle");
        }

        if (IsGrounded())
        {
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.Play("Player jump");
                rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
                
            }

            //Debug.Log("done!");
        }
       
        
    }

    private bool IsGrounded()
    {
         return groundCollider.IsTouchingLayers(LayerMask.GetMask("Ground"));
    }
    /*private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
        }
    }*/

}
