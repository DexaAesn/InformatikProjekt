using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public int playerSpeed = 10;
    private bool facingRight = false;
    public int playerJumpPower = 1250;
    private float moveX;

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        // Controls
            moveX = Input.GetAxis("Horizontal");
            if (Input.GetButtonDown ("Jump"))
            {
                Jump();
            }
        // Animation
            if(moveX != 0)
            {
                GetComponent<Animator>().SetBool ("IsRunning", true);
            }
            else
            {
                GetComponent<Animator>().SetBool ("IsRunning", false);
            }
        // Player Direction
            if (moveX < 0.0f && facingRight == false)
            {
                FlipPlayer();
            }
            else if(moveX > 0.0f && facingRight == true)
            {
                FlipPlayer();
            }
        // Physics
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    void Jump() 
    {
        // Jumping Code
            GetComponent<Rigidbody2D>().AddForce (Vector2.up * playerJumpPower);
    }

    void FlipPlayer()
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

}
