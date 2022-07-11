using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator animator;

    public float playerSpeed = 2.0f;

    Vector2 playerPosition;

     void Update()
    {
        playerPosition.x = Input.GetAxisRaw("Horizontal");
        playerPosition.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", playerPosition.x);
        animator.SetFloat("Vertical", playerPosition.y);

        if (playerPosition.x != 0 || playerPosition.y != 0)
        {
            animator.SetBool("isMoving", true);

        } else
        {
            animator.SetBool("isMoving", false);
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + playerPosition * playerSpeed * Time.fixedDeltaTime);
    }

}
