using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GobacktoMenu : MonoBehaviour
{
    public void BacktoMenu()
    {
        //go to the End Demo
        SceneManager.LoadScene("MainMenu");
    }
}
