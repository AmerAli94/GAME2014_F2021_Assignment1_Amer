// ===============================
// PROGRAM NAME: GAME Programming (T163)
// STUDENT ID : 101206769
// AUTHOR     : AMER ALI MOHAMMED
// CREATE DATE     : SEP 27, 2021
// PURPOSE     : GAME2014_F2021_ASSIGNMENT1
// SPECIAL NOTES:
// ===============================
// Change History:
// Added player movement
//==================================
// Change History:
// Added explosion animations upon collision with enemies
//==================================

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class MovePlayer : MonoBehaviour
{

    private Rigidbody2D rb;
    private float xDir;
    private float moveSpeed = 4.0f;

    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        xDir = CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed;
        rb.velocity = new Vector2(xDir, 0f);
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Enemy")
        {
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
