using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Collider2D player;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("worked");
        if(other == player)
        {
            other.transform.position = new Vector2((other.transform.position.x + 3), other.transform.position.y + 14);
        }
    }
}
