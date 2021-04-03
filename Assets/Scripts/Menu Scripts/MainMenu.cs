using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        //Go to level 1
        SceneManager.LoadScene("SampleScene");
    }

    public void Options()
    {
        //Go to options
        SceneManager.LoadScene("Options");
    }

    public void QuitGame()
    {
        //Quit game
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
