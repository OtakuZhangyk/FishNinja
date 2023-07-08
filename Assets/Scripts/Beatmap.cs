using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beatmap : MonoBehaviour
{
    public GameObject KnifeKitchen;
    public GameObject KnifeSpawn0;

    public void SpawnNote()
    {
        Instantiate(KnifeKitchen, KnifeSpawn0.transform.position, KnifeSpawn0.transform.rotation);
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
