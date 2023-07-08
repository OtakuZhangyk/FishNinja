using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beatmap : MonoBehaviour
{
    public GameObject KnifeNote;
    public GameObject KnifeSpawn0;
    public GameObject KnifeSpawn1;
    public GameObject KnifeSpawn2;

    public void SpawnNote()
    {
        GameObject childKnifeNote = Instantiate(KnifeNote, KnifeSpawn0.transform);
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        //SpawnNote();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
