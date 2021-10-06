// ===============================
// PROGRAM NAME: GAME Programming (T163)
// STUDENT ID : 101206769
// AUTHOR     : AMER ALI MOHAMMED
// CREATE DATE     : SEP 27, 2021
// PURPOSE     : GAME2014_F2021_ASSIGNMENT1
// SPECIAL NOTES:
// ===============================
// Change History:
// Sound manager //clips only work if put in resources folder but not in any other.
//==================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip explodeSound;
    public static AudioSource audioData;

    // Start is called before the first frame update
    void Start()
    {
        explodeSound = Resources.Load<AudioClip>("Explosion2");
        audioData = GetComponent<AudioSource>();

    }

    public static void playExplodeSound()
    {
        audioData.PlayOneShot(explodeSound);
    }
}