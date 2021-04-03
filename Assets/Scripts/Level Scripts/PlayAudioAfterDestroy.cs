using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioAfterDestroy : MonoBehaviour
{
    public GetHitByEnemy otherPingas;
    public AudioSource Audio12;

    private void Update()
    {
        if(otherPingas.lives == 0)
        {
            Debug.Log("Pls help :D"); //this works!
            Audio12.Play();  // plays sound when collided.
            Destroy(Audio12, 19.0f); 
            Destroy(otherPingas, 19.0f);
        }
    }

}
