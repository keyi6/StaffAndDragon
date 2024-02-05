using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public const float SPEED = 15;
    public const float JUMP = 30;
    public const float GRAVITY_SCALE = 10;
    public const float FALLING_GRAVITY_SCALE = 15;
    public const double EPS = 1e-3;


    public float horizontalInput;
    public Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        // Prevent it from rotating when hitting other objects
        rb.freezeRotation = true;
    }


    // Update is called once per frame
    void Update()
    {
        MoveControl();
        JumpControl();
    }

    private void MoveControl()
    {
        // Deal with left/right arrows
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * SPEED * horizontalInput);
    }

    private void JumpControl()
    {
        // Jump only when player is on the ground
        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) <= EPS)
        {
            rb.AddForce(Vector2.up * JUMP, ForceMode2D.Impulse);
        }

        // Make it fall faster
        if (rb.velocity.y > EPS)
        {
            rb.gravityScale = GRAVITY_SCALE;
        }
        else if (rb.velocity.y < -EPS)
        {
            rb.gravityScale = FALLING_GRAVITY_SCALE;
        }
    }
}
