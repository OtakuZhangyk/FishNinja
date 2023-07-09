using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeTrigger : MonoBehaviour
{
    private HitCounter hitCounter;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("HitPlayer");
            if (hitCounter != null)
                hitCounter.IncrementHitCount();
        }
    }

    void Start()
    {
        // Find the HitCounter object
        hitCounter = FindObjectOfType<HitCounter>();

        if (hitCounter == null)
        {
            Debug.Log("HitCounter not found");
        }
    }
}
