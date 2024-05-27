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
    public int minScoreForEntrance;
    void Update()
    {
        timeLeft -= Time.deltaTime;
        timeLeftUI.gameObject.GetComponent<TextMeshProUGUI>().text = ("Time Left: " + (int)timeLeft);
        playerScoreUI.gameObject.GetComponent<TextMeshProUGUI>().text = ("Score: " + playerScore);
        if (timeLeft < 0.1f)
        {
            SceneManager.LoadScene ("Lost");
        }
    }

    void OnTriggerEnter2D(Collider2D trig) 
    {
        if (trig.gameObject.tag == "Coin")
        {
            playerScore = playerScore + 100;
            Destroy(trig.gameObject);
        }
        if(trig.gameObject.tag == "Fire")
        {
            playerScore = playerScore - 50;
        }
        if(trig.gameObject.tag == "Finish")
        { 
            ReachedGoal();
        }
        if(trig.gameObject.tag == "Enemy")
        {
            playerScore = playerScore - 100;
            Destroy(trig.gameObject);
        }
        if(trig.gameObject.tag == "EnemyKill")
        {
            playerScore = playerScore + 100;
        }
        if(trig.gameObject.tag == "Greate")
        {
            playerScore = playerScore - 100;
            Destroy(trig.gameObject);
        }
        if(trig.gameObject.tag == "Finish1")
        { 
            SceneManager.LoadScene ("Level2");
        }
    }

    public void ReachedGoal()
    {
        Debug.Log($"You've reached the supermarket."); 
        Debug.Log($"Your score is: {playerScore}!");

        if(playerScore >= minScoreForEntrance)
        {
            SceneManager.LoadScene ("Won");
            Debug.Log("Congratulations, you have enough money! You may enter. :)");
        }
        else
        {
            SceneManager.LoadScene ("Lost");
            Debug.Log("You don't have enough money to enter. Good luck next time!");
        }
    }
}
