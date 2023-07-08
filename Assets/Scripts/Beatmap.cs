using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beatmap : MonoBehaviour
{
    public GameObject KnifeChild;
    public GameObject KnifeSpawn0;
    public GameObject KnifeSpawn1;
    public GameObject KnifeSpawn2;
    public GameObject KnifeParent;

    public void SpawnNote()
    {
        GameObject Note = Instantiate(KnifeChild, KnifeSpawn1.transform.position, KnifeSpawn1.transform.rotation, KnifeParent.transform);
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
