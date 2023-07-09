using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMovement : MonoBehaviour
{

    private CharacterController characterController;
    private Animator animator;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        characterController.Move(move * Time.deltaTime * speed);

        Animator parentAnimator = GetComponentInParent<Animator>();
        if (Input.GetButtonDown("Flip"))
        {
            //animator.Play("Jump");
            
        }
        else
        {
            //animator.Play("Swim");
        }
    }
}
