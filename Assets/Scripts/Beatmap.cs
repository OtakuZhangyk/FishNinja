using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beatmap : MonoBehaviour
{
    public GameObject KnifeChild;
    public GameObject KnifeSpawn0;//topleft
    public GameObject KnifeSpawn1;//bottomright
    public GameObject KnifeSpawn2;
    public GameObject KnifeParent;
    private GameObject[] SpawnPoints;

    public void SpawnNote()
    {
        int randomIndex = Random.Range(0, 3);
        if (randomIndex == 2)
            Instantiate(KnifeChild, SpawnPoints[randomIndex].transform.position, SpawnPoints[randomIndex].transform.rotation, KnifeParent.transform);
        else
        {
            Vector3 cubeMin = KnifeSpawn0.transform.position;
            Vector3 cubeMax = KnifeSpawn1.transform.position;

            //float xMin = Mathf.Min(cubeMin.x, cubeMax.x);
            //float xMax = Mathf.Max(cubeMin.x, cubeMax.x);

            float yMin = Mathf.Min(cubeMin.y, cubeMax.y);
            float yMax = Mathf.Max(cubeMin.y, cubeMax.y);

            float zMin = Mathf.Min(cubeMin.z, cubeMax.z);
            float zMax = Mathf.Max(cubeMin.z, cubeMax.z);

            //float x = Random.Range(xMin, xMax);
            float x = cubeMin.x;
            float y = Random.Range(yMin, yMax);
            float z = Random.Range(zMin, zMax);

            
            Vector3 randomPosition = new Vector3(x, y, z);

            Vector3 cubeCenter = (cubeMin + cubeMax) / 2;
            Vector3 dir2Center = cubeCenter - randomPosition;
            Quaternion rotation = Quaternion.LookRotation(dir2Center);
            Vector3 eulerRotation = rotation.eulerAngles;
            if (z < cubeCenter.z)
                eulerRotation.y += 180f;
            rotation = Quaternion.Euler(eulerRotation);

            Instantiate(KnifeChild, randomPosition, rotation, KnifeParent.transform);
        }
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
