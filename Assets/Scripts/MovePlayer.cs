using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public int playerSpeed = 10;
    private bool facingRight = false;
    public int playerJumpPower = 1250;
    private float moveX;
    public GameObject coin;

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        PlayerRaycast();
    }

    void PlayerMove()
    {
        // Controls
            moveX = Input.GetAxis("Horizontal");
            if (Input.GetButtonDown ("Jump"))
            {
                Jump();
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

    void PlayerRaycast()
    {
        RaycastHit2D rayUp = Physics2D.Raycast (transform.position, Vector2.up);
        if(rayUp != null && rayUp.collider != null && rayUp.distance < 0.9f && rayUp.collider.name == "MysteryBlock")
        {
            Destroy (rayUp.collider.gameObject);
            GameObject newInstance = Instantiate(coin, Vector2(transform.position.x, (transform.position.y + 1), transform.rotation);
        }
    }
}
