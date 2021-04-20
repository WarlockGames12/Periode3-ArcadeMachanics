using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompasScript : MonoBehaviour
{
    public Transform Compas;
    public float agroRange;
    // Update is called once per frame
    void Update()
    {
        if (Compas == null)
        {
            return;
        }
        if (Vector2.Distance(transform.position, Compas.position) < agroRange) //Agro range
        {  //rotate to look at the player
            transform.LookAt(Compas.position);
            transform.Rotate(new Vector2(0, -90), Space.Self);//correcting the original rotation
        }
    }
}
