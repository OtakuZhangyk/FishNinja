using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishAnchor : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Flip"))
        {
            if (!animator.IsInTransition(0))
            {
                animator.SetTrigger("Flipping");
            }
            
        }
    }
}