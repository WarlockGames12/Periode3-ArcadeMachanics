using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    public Transform spshipsprite;

    void FixedUpdate()
    {
        transform.position = new Vector3(spshipsprite.position.x, spshipsprite.position.y, transform.position.z);
    }
}
