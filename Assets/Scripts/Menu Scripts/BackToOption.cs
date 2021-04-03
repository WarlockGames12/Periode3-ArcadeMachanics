using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToOption : MonoBehaviour
{
    public void Option()
    {
        //Go back to options
        Debug.Log("Please work!");
        SceneManager.LoadScene("Options");
    }
}
