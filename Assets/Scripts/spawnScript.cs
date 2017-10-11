using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour {

    public GameObject enemy;
    public GameObject enemyPoweredUp;
    private SpriteRenderer rd;

    public float spawnTime = 1.2f;

    public static bool AllowSpawn = true;

    // Use this for initialization
    void Start () {
        StartSpawn();
	}
	
	// Update is called once per frame
	void Update () {
		
        if (AllowSpawn == false)
        {
            CancelInvoke();
        }

	}

    public void StartSpawn()
    {
        AllowSpawn = true;
        InvokeRepeating("addEnemy", 0, spawnTime);
    }

    void addEnemy()
    {
        bool isPowerUp = false;
        float determiner = Random.Range(0.0f, 10.0f);

        if(determiner > 9.0f)
        {
            isPowerUp = true;
        }

        if(isPowerUp)
        {
            rd = GetComponent<SpriteRenderer>();
            float x1 = transform.position.x - rd.bounds.size.x / 2;
            float x2 = transform.position.x + rd.bounds.size.x / 2;

            Vector2 spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);

            Instantiate(enemyPoweredUp, spawnPoint, Quaternion.identity);
        }
        else
        {
            rd = GetComponent<SpriteRenderer>();
            float x1 = transform.position.x - rd.bounds.size.x / 2;
            float x2 = transform.position.x + rd.bounds.size.x / 2;

            Vector2 spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);

            Instantiate(enemy, spawnPoint, Quaternion.identity);
        }

        //GameObject enemyInstance = Instantiate(enemy, spawnPoint, Quaternion.identity) as GameObject;
        //enemyInstance.GetComponent<Rigidbody2D>().AddForce(new Vector2(100.0f, 5.0f));
    }

}
