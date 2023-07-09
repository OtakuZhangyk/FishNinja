using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishAnchor : MonoBehaviour
{
    private Animator animator;
    private Rigidbody rb;
    private bool jumping;

    private bool isCurrentlyColliding;

    void OnCollisionEnter(Collision col)
    {
        isCurrentlyColliding = true;
    }

    void OnCollisionExit(Collision col)
    {
        isCurrentlyColliding = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        jumping = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isCurrentlyColliding && Input.GetButtonDown("Jump"))
        {
            jumping = true;
        }
    }

    private void FixedUpdate()
    {

        float flipDir = Input.GetAxis("Flip");
        rb.AddRelativeTorque(new Vector3(0, 0, -10 * flipDir), ForceMode.VelocityChange);

        float rotateDir = Input.GetAxis("Rotate");
        rb.AddTorque(new Vector3(0, 5 * rotateDir, 0), ForceMode.VelocityChange);

        if (jumping)
        {
            rb.AddForce(new Vector3(0, 10, 0), ForceMode.VelocityChange);
            jumping = false;
        }
    }
}
