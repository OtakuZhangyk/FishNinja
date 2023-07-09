using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HitCounter : MonoBehaviour
{
    public int hitCount = 0;
    public TextMeshProUGUI hitCountText;

    void Awake()
    {
        // This line prevents the object from being destroyed when loading a new scene.
        DontDestroyOnLoad(gameObject);
    }

    public void IncrementHitCount()
    {
        Debug.Log("Increment");
        hitCount++;
        hitCountText.text = "Hit Count: " + hitCount.ToString();
        Debug.Log("Hit Count: " + hitCount.ToString());
    }
    
    // Start is called before the first frame update
    void Start()
    {
        //hitCountText = GetComponentInChildren<TextMeshProUGUI>();

        if (hitCountText == null)
        {
            Debug.Log("hitCountText not found");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
