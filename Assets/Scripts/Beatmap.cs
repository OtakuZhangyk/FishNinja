using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Beatmap : MonoBehaviour
{
    public GameObject KnifeChild;
    public GameObject KnifeSpawn0;//topleft
    public GameObject KnifeSpawn1;//bottomright
    public GameObject KnifeSpawn2;
    public GameObject Fish;
    public GameObject KnifeParent;
    private GameObject[] SpawnPoints;

    public void SpawnNote(int i = 0)
    {
        //if (i != 0)
        if (true)
        {
            int randomIndex = Random.Range(0, 3);
            if (randomIndex == 2)
            {
                Vector3 SpawnPosition = KnifeSpawn2.transform.position;
                SpawnPosition.x += Fish.transform.position.x;
                SpawnPosition.z += Fish.transform.position.z;
                Instantiate(KnifeChild, SpawnPosition, KnifeSpawn2.transform.rotation, KnifeParent.transform);
            }
            else
            {
                Vector3 cubeMin = KnifeSpawn0.transform.position;
                Vector3 cubeMax = KnifeSpawn1.transform.position;

                float xMin = Mathf.Min(cubeMin.x, cubeMax.x);
                float xMax = Mathf.Max(cubeMin.x, cubeMax.x);

                //float yMin = Mathf.Min(cubeMin.y, cubeMax.y);
                //float yMax = Mathf.Max(cubeMin.y, cubeMax.y);

                float zMin = Mathf.Min(cubeMin.z, cubeMax.z);
                float zMax = Mathf.Max(cubeMin.z, cubeMax.z);

                float x = Random.Range(xMin, xMax);
                float y = cubeMin.y;
                float z = Random.Range(zMin, zMax);

                
                Vector3 randomPosition = new Vector3(x, y, z);
                randomPosition.x += Fish.transform.position.x;
                randomPosition.z += Fish.transform.position.z;

                //Vector3 cubeCenter = (cubeMin + cubeMax) / 2;
                //Vector3 dir2Center = cubeCenter - randomPosition;
                Quaternion rotation = KnifeParent.transform.rotation;
                Vector3 eulerRotation = rotation.eulerAngles;
                int randomRotateAngleY = Random.Range(-2,2);
                eulerRotation.y += randomRotateAngleY * 45;
                rotation = Quaternion.Euler(eulerRotation);
                //if (z < cubeCenter.z)
                //    eulerRotation.y += 180f;
                //rotation = Quaternion.Euler(eulerRotation);

                Instantiate(KnifeChild, randomPosition, rotation, KnifeParent.transform);
            }
        }
    }

    public void GameOver()
    {
        //get score
        //


        //SceneTransition sceneTransition = GetComponent<SceneTransition>();
        //sceneTransition.FadeToNextScene();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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
