using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMystery : MonoBehaviour
{
        [SerializeField] private GameObject coin;
        [SerializeField] private GameObject block;
        [SerializeField] private Collider2D player;
        private void OnTriggerEnter2D(Collider2D other) 
        {
            if(coin != null && other == player)
            {
                Debug.Log("if statement called");   
                GameObject newInstance = Instantiate(block, transform.position, transform.rotation);
                GameObject newInstance2 = Instantiate(coin, new Vector2 (transform.position.x , (transform.position.y + 1)), transform.rotation);
                Destroy(this.gameObject);
            }
        }
}
