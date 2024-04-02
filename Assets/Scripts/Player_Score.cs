using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_Score : MonoBehaviour
{
    public float timeLeft = 120;
    public int playerScore = 0;
    public GameObject timeLeftUI;
    public GameObject playerScoreUI;
    void Update()
    {
        timeLeft -= Time.deltaTime;
        timeLeftUI.gameObject.GetComponent<TextMeshProUGUI>().text = ("Time Left: " + (int)timeLeft);
        playerScoreUI.gameObject.GetComponent<TextMeshProUGUI>().text = ("Score: " + playerScore);
        if (timeLeft < 0.1f)
        {
            SceneManager.LoadScene ("Menu");
        }
    }

    void OnTriggerEnter2D(Collider2D trig) 
    {
        if (trig.gameObject.tag == "Finish")
        {
            CountScore();    
        }
        if (trig.gameObject.tag == "Coin")
        {
            playerScore = playerScore + 100;
            Destroy(trig.gameObject);
        }
    }

    void CountScore()
    {
        playerScore = playerScore + (int)(timeLeft * 2);
        Debug.Log(playerScore);
    }
}
