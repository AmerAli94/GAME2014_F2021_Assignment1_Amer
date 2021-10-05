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
