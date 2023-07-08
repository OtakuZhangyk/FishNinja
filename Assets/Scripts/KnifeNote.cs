using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeNote : MonoBehaviour
{
    private float dropSpeed = 40f;
    private float endy = 23.8f;
    private float initialWaitSecond = 0.4f;
    private float endWaitSecond = 0.2f;

    public AudioClip yellClip;
    public AudioClip dropClip;
    public AudioClip hitClip;
    private AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(NoteBehavior());
    }

    private IEnumerator NoteBehavior()
    {
        audioSource.clip = yellClip;
        audioSource.Play();
        yield return new WaitForSeconds(initialWaitSecond);

        // Start dropping
        audioSource.clip = dropClip;
        audioSource.Play();
        if (transform.position.y > endy)
        {
            while (transform.position.y > endy)
            {
                transform.position -= new Vector3(0, dropSpeed * Time.deltaTime, 0);
                yield return null;
            }

            audioSource.clip = hitClip;
            audioSource.Play();
        }
        else
        {
            while (transform.position.z < 14.4f)
            {
                transform.position += new Vector3(0, 0, 2f * dropSpeed * Time.deltaTime);
                yield return null;
            }
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
