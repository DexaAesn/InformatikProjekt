using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Collider2D player;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.name == "bob")
        {
           other.transform.position = new Vector2(other.transform.position.x, other.transform.position.y + 13); 
        }
    }
}
