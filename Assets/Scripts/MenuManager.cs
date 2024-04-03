using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    void Update()
    {
        LoadLevel1();
        LoadLevel2();
    }

    void LoadLevel1()
    {
        if(Input.GetButtonDown ("1"))
        {
            SceneManager.LoadScene ("Level1");
        }
    }

    void LoadLevel2()
    {
        if(Input.GetButtonDown ("2"))
        {
            SceneManager.LoadScene ("Level2");
        }
    }
}
