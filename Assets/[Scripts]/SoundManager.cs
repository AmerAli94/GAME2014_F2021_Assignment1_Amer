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