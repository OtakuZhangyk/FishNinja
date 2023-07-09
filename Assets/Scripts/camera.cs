using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject Fish;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 fishDir = Fish.transform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(fishDir);
        transform.rotation = rotation;
    }
}
