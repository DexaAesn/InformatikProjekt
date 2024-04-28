using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemySpeed = 7;
    bool facingRight = true;
    private float moveX = 1;
    // public Collider2D treeCollider;

    void Update()
    {
        MoveEnemy();
    }

    public void MoveEnemy()
    {
        // Physics
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (moveX * enemySpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Test")
        {
            Debug.Log("Collision worked");
            if (moveX < 0.0f && facingRight == false)
            {
                moveX = 1;
                Debug.Log("if 1 called");
                FlipEnemy();
            }
            else if(moveX > 0.0f && facingRight == true)
            {
                moveX = -1;
                Debug.Log("if 2 called");
                FlipEnemy();
            }
        }
    }
    public void FlipEnemy()
    {
        Debug.Log("method called");
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x = -1;
        transform.localScale = localScale;
    }

}
