using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeNote : MonoBehaviour
{
    private float dropSpeed = 70f;
    private float endy = 23.8f;
    private float initialWaitSecond = 0.5f;
    private float endWaitSecond = 0.175f;

    public AudioClip yellClip;
    public AudioClip yellClip2;
    public AudioClip dropClip;
    public AudioClip hitClip;
    private AudioSource audioSource;

    private KnifeTrigger otherScript;
    
    // Start is called before the first frame update
    void Start()
    {
        // Get a reference to the other script
        otherScript = GetComponent<KnifeTrigger>();
        // Check if the other script is found, if not, log an error message
        if (otherScript == null)
        {
            Debug.LogError("Other script not found!");
            return;
        }
        // Disable the other script
        otherScript.enabled = false;

        audioSource = GetComponent<AudioSource>();
        StartCoroutine(NoteBehavior());
    }

    private IEnumerator NoteBehavior()
    {
        if (transform.position.y > endy)
        {
            audioSource.clip = yellClip;
            audioSource.Play();
            for (float i = 0f; i < initialWaitSecond; i+=Time.deltaTime)
            {
                transform.position += new Vector3(0, 5f * Time.deltaTime, 0);
                yield return null;
            }
        }
        else
        {
            audioSource.clip = yellClip2;
            audioSource.Play();
            for (float i = 0f; i < initialWaitSecond; i+=Time.deltaTime)
            {
                transform.position -= new Vector3(0, 0, 5f * Time.deltaTime);
                yield return null;
            }
        }
        //yield return new WaitForSeconds(initialWaitSecond);

        // Start dropping
        audioSource.clip = dropClip;
        audioSource.Play();
        otherScript.enabled = true;
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
