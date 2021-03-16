using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        //NextLevel = SceneManager.GetActiveScene().buildIndex + 1;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        // Application.LoadLevel(loadLevel);
        //SceneManager.LoadScene(nextLevel);

    }

    // Update is called once per frame
    void Update()
    {

    }
}    