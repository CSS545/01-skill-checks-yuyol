using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/*
 +timed spawner on Apple and Poo
   +Spawn center follows the player
   +Spawn in circular
   +Spawn radius = camera width (adjustable by diff device)
*/
public class Spawner : MonoBehaviour
{
    public GameObject spawnPrefabPoo;
    public GameObject spawnPrefabApple;
    public GameObject player;
    
    private float currrentPooSpawnTime = 0;
    private float currrentAppSpawnTime = 0;

    private float CircleRadius;
    private int PooNum;

    public float pooSpawnTime = 5;
    public float AppleSpawnTime = 2;

    // Start is called before the first frame update
    void Start()
    {
        CircleRadius = Camera.main.orthographicSize *
                                    Camera.main.aspect;
        PooNum = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null) {
            transform.position = player.transform.position;
        }
        currrentPooSpawnTime += Time.deltaTime;
        currrentAppSpawnTime += Time.deltaTime;

        if (currrentPooSpawnTime > pooSpawnTime)
        {
            SpawnbyType(spawnPrefabPoo);

            PlayerPrefs.SetInt("CurrentPoo", PooNum++);
            currrentPooSpawnTime = 0;
        }
        if (currrentAppSpawnTime > AppleSpawnTime)
        {
            SpawnbyType(spawnPrefabApple);
            
            currrentAppSpawnTime = 0;
        }
        

    }

    public void SpawnbyType(GameObject prefab) {

        Instantiate(prefab, 
                    RandomCircle(transform.position, CircleRadius), 
                    Quaternion.identity);

    }



    //https://answers.unity.com/questions/714835/best-way-to-spawn-prefabs-in-a-circle.html

    Vector3 RandomCircle (Vector3 center, float radius) {
        float ang = Random.value * 360;
        Vector3 pos;
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        pos.z = center.z;
        return pos;
    }
}
