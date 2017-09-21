using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour {

    public GameObject enemy;
    private SpriteRenderer rd; 

    public float spawnTime = 2.0f;

	// Use this for initialization
	void Start () {
        InvokeRepeating("addEnemy", 0, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void addEnemy()
    {
        //rd = GetComponent<Renderer>();
        rd = GetComponent<SpriteRenderer>();
        float x1 = transform.position.x - rd.bounds.size.x / 2;
        float x2 = transform.position.x + rd.bounds.size.x / 2;

        Vector2 spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);

        Instantiate(enemy, spawnPoint, Quaternion.identity);
    }

}
