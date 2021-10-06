// ===============================
// PROGRAM NAME: GAME Programming (T163)
// STUDENT ID : 101206769
// AUTHOR     : AMER ALI MOHAMMED
// CREATE DATE     : SEP 27, 2021
// PURPOSE     : GAME2014_F2021_ASSIGNMENT1
// SPECIAL NOTES:
// ===============================
// Change History:
// Added Enemy Movement speed and bullet collision triggers
//==================================
// Change History:
// Added sound and updated player damage
//==================================

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 0.5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0f, -speed);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Bullet")
        {
            
            Destroy(gameObject);
        }

        if (col.tag == "Player")
        {
            SoundManager.playExplodeSound();
            HealthManager.health -= 1;
            Destroy(gameObject);
        }
    }
}
