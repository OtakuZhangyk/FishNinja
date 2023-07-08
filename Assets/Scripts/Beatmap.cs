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
    private GameObject[] SpawnPoints;

    public void SpawnNote()
    {
        bool if_note = (Random.Range(0, 10) > 4);
        int randomIndex = Random.Range(0, 3);
        if (if_note)
            Instantiate(KnifeChild, SpawnPoints[randomIndex].transform.position, SpawnPoints[randomIndex].transform.rotation, KnifeParent.transform);
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnPoints = new GameObject[] {KnifeSpawn0, KnifeSpawn1, KnifeSpawn2};
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
