using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Transform player;

    private Rigidbody2D rb;

    public Vector2 enemyVec;
    private Vector2 enemyOrigPos;

    public AudioSource deathSFSource;
    public AudioClip deathClip;

    public float enemySpeed;
    private float currrentTime;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        enemyOrigPos = rb.transform.position;
        enemySpeed = 1;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        float vol = Random.Range(0.1f, 0.3f);
        if (collision.gameObject.CompareTag("Player")) {
            if (currrentTime >  5 + Random.Range(0, 5f)) {
                deathSFSource.PlayOneShot(deathClip, vol);
                currrentTime = 0;
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        currrentTime += Time.deltaTime;
        enemyOrigPos = rb.transform.position;

        //Vector2 aim = player.position;
        enemyVec = ((Vector2)player.position - enemyOrigPos).normalized;


        rb.velocity = new Vector2 (enemyVec.x * enemySpeed,
                            enemyVec.y * enemySpeed);

    }
}
