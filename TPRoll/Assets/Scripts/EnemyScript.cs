using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Transform player;

    private Rigidbody2D rb;

    public Vector2 enemyVec;
    private Vector2 enemyDestination;
    private Vector2 enemyOrigPos;



    public float enemySpeed;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        enemyOrigPos = rb.transform.position;
        enemySpeed = 1;

    }

    // Update is called once per frame
    void Update()
    {
        
        enemyOrigPos = rb.transform.position;

        Vector2 aim = player.position;
        enemyVec = (aim - enemyOrigPos).normalized;


        rb.velocity = new Vector2 (enemyVec.x * enemySpeed,
                            enemyVec.y * enemySpeed);

    }
}
