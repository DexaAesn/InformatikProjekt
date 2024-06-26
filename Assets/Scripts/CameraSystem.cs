using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    private GameObject player;
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;
    public float abovePlayer;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    private void LateUpdate() 
    {
        float x = Mathf.Clamp (player.transform.position.x, xMin, xMax);
        float y = Mathf.Clamp (player.transform.position.y, yMin, yMax);
        gameObject.transform.position = new Vector3(x, (y + abovePlayer), gameObject.transform.position.z);
    }
}
