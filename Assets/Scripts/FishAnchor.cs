using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishAnchor : MonoBehaviour
{
    private Animator animator;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Flip"))
        {
            float flipDir = Input.GetAxis("Flip");
            rb.AddRelativeTorque(new Vector3(0, 0, -10 * flipDir), ForceMode.VelocityChange);
            
            
        }
        if (Input.GetButtonDown("Rotate"))
        {
            float rotateDir = Input.GetAxis("Rotate");
            rb.AddTorque(new Vector3(0, 5 * rotateDir, 0), ForceMode.VelocityChange);
        }
    }
}
