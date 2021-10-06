// ===============================
// PROGRAM NAME: GAME Programming (T163)
// STUDENT ID : 101206769
// AUTHOR     : AMER ALI MOHAMMED
// CREATE DATE     : SEP 27, 2021
// PURPOSE     : GAME2014_F2021_ASSIGNMENT1
// SPECIAL NOTES:
// ===============================
// Change History:
// Added bottom collider to detect enemy collision at the bottom of screen
//==================================
// Change History:
// Added explosion trigger for the animation to be played on player.
//==================================

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollider : MonoBehaviour
{

    public Transform playerTransform;
    public GameObject explosion;


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Enemy")
        {
            HealthManager.health -= 1;
            SoundManager.playExplodeSound();
            playExplosion();
            Destroy(col.gameObject);
        }
    }


    private void playExplosion()
    {
        GameObject e = Instantiate(explosion) as GameObject;
        //spawning the explosion animation at player transform.
        e.transform.position = playerTransform.position;
        Destroy(e, 0.50f);
    }
}
