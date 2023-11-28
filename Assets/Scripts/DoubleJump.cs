using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJump : MonoBehaviour
{
    // Start is called before the first frame update
    public float jumpForce = 10f;
    public int maxJumps = 2;

    private int jumpsRemaining;
    void Start()
    {
        jumpsRemaining = maxJumps;
    }

    public void TryJump(Rigidbody2D rb)
    {
        if (jumpsRemaining > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            jumpsRemaining--;
        }
    }
    public void ResetJumps()
    {
        jumpsRemaining = maxJumps;
    }
    // Update is called once per frame
    /*void Update()
    {
        
    } */
}
