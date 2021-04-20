using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashMechanic : MonoBehaviour
{
    public DashState dashState; 
    public float dashTimer; //the maximum time when dashing
    public float maxDash = 20f; //the maximum time of the dash cooldown
    public GameObject[] Enemies; //make a list for Enemies
    public GameObject[] Boxes; //make a list for Box
    //public List<ParticleSystem> ParticleExplosionEnemy; //Make a list for Particle System enemies
    //public List<GameObject> ParticlePointEnemies; //Make a list for Particlepoints
    //public List<ParticleSystem> ParticleExplosionBox; //Make a list for ParticleExplosions for the Box
    //public List<GameObject> ParticlePointBox; //Make a list for Particlepoint box


    public Vector2 savedVelocity;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Enemy") && dashState == DashState.Dashing)
        {
            AudioSource audioEnemy = GetComponent<AudioSource>();
            audioEnemy.Play();
            Destroy(col.gameObject, audioEnemy.clip.length);
           //Instantiate(
           //     ParticleExplosionEnemy[0],
           //     ParticlePointEnemies[0].transform.position,
           //     Quaternion.identity
          //  );
            
        }

        if (col.gameObject.CompareTag("Box") && dashState == DashState.Dashing)
        {
            AudioSource audioBox = GetComponent<AudioSource>();
            audioBox.Play();
            Destroy(col.gameObject, audioBox.clip.length);
           // Instantiate(
            //    ParticleExplosionBox[0],
            //    ParticlePointBox[0].transform.position,
           //     Quaternion.identity
          //   );
        }
    }
    void Update()
    {
        switch (dashState)
        {
            case DashState.Ready: //for when the dash is ready
                var isDashKeyDown = Input.GetKeyDown(KeyCode.LeftShift);
                if (isDashKeyDown)
                {
                    savedVelocity = GetComponent<Rigidbody2D>().velocity;
                    GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x * 3f, GetComponent<Rigidbody2D>().velocity.y);
                    dashState = DashState.Dashing;

                }
                break;
            case DashState.Dashing: //for when your are dashing
                dashTimer += Time.deltaTime * 3;
                if (dashTimer >= maxDash)
                {
                    dashTimer = maxDash;
                    GetComponent<Rigidbody2D>().velocity = savedVelocity;
                    dashState = DashState.Cooldown;

                    
                }
                
                break;
            case DashState.Cooldown: //for after dashing
                dashTimer -= Time.deltaTime;
                if (dashTimer <= 0)
                {
                    dashTimer = 0;
                    dashState = DashState.Ready;
                }
                break;
        }
    }
}


public enum DashState
{
    Ready,
    Dashing,
    Cooldown
}


