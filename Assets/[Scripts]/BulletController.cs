// ===============================
// PROGRAM NAME: GAME Programming (T163)
// STUDENT ID : 101206769
// AUTHOR     : AMER ALI MOHAMMED
// CREATE DATE     : SEP 27, 2021
// PURPOSE     : GAME2014_F2021_ASSIGNMENT1
// SPECIAL NOTES:
// ===============================
// Change History:
// Added Bullet Movement
//==================================
//==================================
// Change History:
// Added Explosions to bullet reactions
//==================================


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BulletController : MonoBehaviour
{
    public Rigidbody2D rb;
    public int speed = 50;

    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = Vector2.up * speed;
        
    
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Enemy")
        {
            ScoreManager.score += 10;
            SoundManager.playExplodeSound();
            Destroy(gameObject);
            playExplosion();
          
        }
    }

    private void playExplosion()
    {
        GameObject e = Instantiate(explosion) as GameObject;
        e.transform.position = transform.position;
       
        Destroy(e, 0.50f);
    }
}
