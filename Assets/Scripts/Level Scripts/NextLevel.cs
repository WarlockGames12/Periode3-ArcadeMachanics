using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    [SerializeField] private int _levelToLoad = 2;

    // Start is called before the first frame update
    private void Start()
    {

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Portal")
            SceneManager.LoadScene(_levelToLoad);

    }

    // Update is called once per frame
    void Update()
    {

    }
}    