using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnPrefabPoo;
    public GameObject spawnPrefabApple;
    public GameObject player;
    
    private float currrentPooSpawnTime = 0;
    private float currrentAppSpawnTime = 0;

    private float CircleRadius;

    public float pooSpawnTime = 5;
    public float AppleSpawnTime = 2;

    // Start is called before the first frame update
    void Start()
    {
        CircleRadius = Camera.main.orthographicSize *
                                    Camera.main.aspect;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform != null) {
            transform.position = player.transform.position;
        }
        currrentPooSpawnTime += Time.deltaTime;
        currrentAppSpawnTime += Time.deltaTime;

        if (currrentPooSpawnTime > pooSpawnTime)
        {
            Instantiate(spawnPrefabPoo, 
                        RandomCircle(transform.position, CircleRadius), 
                        Quaternion.identity);
            currrentPooSpawnTime = 0;
        }
        if (currrentAppSpawnTime > AppleSpawnTime)
        {
            Instantiate(spawnPrefabApple,
                        RandomCircle(transform.position, CircleRadius),
                        Quaternion.identity);
            currrentAppSpawnTime = 0;
        }
        

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
