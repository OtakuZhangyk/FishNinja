using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeNote : MonoBehaviour
{
    private float dropSpeed = 6f;
    private float endy = 23.9f;
    private float initialWaitSecond = 1f;
    private float endWaitSecond = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(NoteBehavior());
    }

    private IEnumerator NoteBehavior()
    {
        yield return new WaitForSeconds(initialWaitSecond);

        // Start dropping
        while (transform.position.y > endy)
        {
            transform.position -= new Vector3(0, dropSpeed * Time.deltaTime, 0);
            yield return null;
        }

        yield return new WaitForSeconds(endWaitSecond);

        // Make the note disappear
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}