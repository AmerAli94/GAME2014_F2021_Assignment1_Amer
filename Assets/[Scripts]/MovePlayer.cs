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
