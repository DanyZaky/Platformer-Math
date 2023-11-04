using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator anim;
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    private bool isJumping = false;

    public bool isMoving = false;
    public bool isLeft;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isMoving = false;
    }

    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isJumping = true;
        }

        if(moveInput < 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        /*
        if(!isJumping)
        {
            if (moveInput == 0)
            {
                anim.Play("Idle");
            }
            else
            {
                anim.Play("Run");
            }
        }
        else
        {
            anim.Play("Jump");
        }*/

        if(isMoving)
        {
            if(isLeft)
            {
                MoveLeft();
                if(!isJumping)
                {
                    anim.Play("Run");
                }
            }
            else
            {
                MoveRight();
                if (!isJumping)
                {
                    anim.Play("Run");
                }
            }
        }
        else
        {
            if(!isJumping)
            {
                anim.Play("Idle");
            }
        }

        if(isJumping)
        {
            anim.Play("Jump");
        }
        
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false; 
        }
    }

    public void Jump()
    {
        if (!isJumping)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isJumping = true;
        }
    }

    public void MoveLeft()
    {
        rb.velocity = new Vector2(-1 * moveSpeed, rb.velocity.y);
        Debug.Log("kiri");
        gameObject.GetComponent<SpriteRenderer>().flipX = true;
    }

    public void MoveRight()
    {
        rb.velocity = new Vector2(1 * moveSpeed, rb.velocity.y);
        Debug.Log("kanan");
        gameObject.GetComponent<SpriteRenderer>().flipX = false;
    }
}
