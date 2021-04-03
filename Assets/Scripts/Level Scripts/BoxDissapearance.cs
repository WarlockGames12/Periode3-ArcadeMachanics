using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDissapearance : MonoBehaviour
{
    public GameObject explosion;
    private void Start()
    {
        explosion.GetComponent<Animator>().enabled=false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        explosion.GetComponent<Animator>().enabled = true;
        Destroy(explosion, 0.8f);
        Destroy(gameObject);
    }
}

