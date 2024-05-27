using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    void Update()
    {
        LoadLevel0();
        LoadLevel1();
        LoadMenu();
    }

    void LoadLevel0()
    {
        if(Input.GetButtonDown ("0"))
        {
            SceneManager.LoadScene ("Level0");
        }
    }

    void LoadLevel1()
    {
        if(Input.GetButtonDown ("1"))
        {
            SceneManager.LoadScene ("Level1");
        }
    }
    void LoadMenu()
    {
        if(Input.GetButtonDown("3"))
        {
            SceneManager.LoadScene ("Menu");
        }
    }
}
