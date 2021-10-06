// ===============================
// PROGRAM NAME: GAME Programming (T163)
// STUDENT ID : 101206769
// AUTHOR     : AMER ALI MOHAMMED
// CREATE DATE     : SEP 27, 2021
// PURPOSE     : GAME2014_F2021_ASSIGNMENT1
// SPECIAL NOTES:
// ===============================
// Change History:
// Player screen bounds so the player is not going off the screen
//==================================

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBounds : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -1.8f, 1.8f), transform.position.y, transform.position.z);
    }
}
