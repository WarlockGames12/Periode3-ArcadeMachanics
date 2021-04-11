﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GetHitByEnemy : MonoBehaviour
{
    public GameObject GameOverScreen, ParticlesExplosion; //Game Over Gameobject and Unity's Particle system, the best system of the whole world
    public bool GameOver = false; //Question if the Game Over UI is true or false
    public Transform ExplosionPoint; //make a gameobject of the explosion point
    public Camera_Follow other; //Destroy Camera 
    public EnemyBehaviour enemyView; //Destroy view from enemy
    public List<EnemyBehaviour> enemyBehaviourList; //You can choose how many Enemies there are because you can make a list out of it, making the code a bit lighter
    public PlayAudioAfterDestroy Audio12; //?????
    public GameObject[] livesSprites; //Gameobject Lives
    public int lives = 3; //player has 3 lives
    void Start()
    {
        //begin the gameover screen transparent
        GameOverScreen.SetActive(false);
        enemyBehaviourList = new List<EnemyBehaviour>();
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        //once the Enemy collides with player a life will be destroyed, once all lives are gone, player gets destroyed and plays a sound
        if (col.gameObject.CompareTag("Enemy"))
        {
            //Destroy 1 life at a time
            Destroy(livesSprites[lives-1]);
            lives -= 1; //Live = 3 - 1 collision = 2 lives and so on for if it happens another time
            if(lives == 0) //if the Player has no lives, it will get you a game over UI
            {
                
                GameOverScreen.SetActive(true);
                GameOver = true;
                Destroy(other); //Destroy Camera 
                Destroy(enemyView); //Destroy Enemy view :D
                Destroy(Audio12, 6.0f); //Play first the Audio before it destroys itself...
                Destroy(gameObject); //Destroy player
                Instantiate(
                   ParticlesExplosion, //Particle system & Explosion point will stay 
                   ExplosionPoint.position,
                   Quaternion.identity
                );
            }
        }

    }

}
