using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    [SerializeField] private int _levelToLoad;

    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log(_levelToLoad); 
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene(_levelToLoad, LoadSceneMode.Single);
        }
    }

}    