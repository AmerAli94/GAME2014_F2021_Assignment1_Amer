// ===============================
// PROGRAM NAME: GAME Programming (T163)
// STUDENT ID : 101206769
// AUTHOR     : AMER ALI MOHAMMED
// CREATE DATE     : SEP 27, 2021
// PURPOSE     : GAME2014_F2021_ASSIGNMENT1
// SPECIAL NOTES:
// ===============================
// Change History:
//
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
}
