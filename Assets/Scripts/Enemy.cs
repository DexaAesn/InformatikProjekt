using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemySpeed = 7;
    bool facingRight = true;
    private float moveX = 1;
    private SpriteRenderer mySpriteRenderer;

    private void Start() 
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        MoveEnemy();
    }

    public void MoveEnemy()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (moveX * enemySpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Tree")
        {
            if (moveX < 0.0f && facingRight == false)
            {
                moveX = 1;
                mySpriteRenderer.flipX = true;
                FlipEnemy();
            }
            else if(moveX > 0.0f && facingRight == true)
            {
                moveX = -1;
                mySpriteRenderer.flipX = false;
                FlipEnemy();
            }
        }
    }
    public void FlipEnemy()
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x = -1;
        transform.localScale = localScale;
    }

}
