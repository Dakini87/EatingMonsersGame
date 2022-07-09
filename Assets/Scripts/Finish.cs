using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    
    public void PlayGame()
    {
        SceneManager.LoadScene("MainMenu");

    }

    public void QuitGame()


    {
        SceneManager.LoadScene("Level2");;
    }
}

