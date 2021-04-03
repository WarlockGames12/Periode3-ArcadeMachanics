using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlsmenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Menu()
    {
        //go to the Main Menu screen
        SceneManager.LoadScene("MainMenu");
    }

    public void Controls()
    {
        //go to the controls screen
        SceneManager.LoadScene("Controls");
    }
}
