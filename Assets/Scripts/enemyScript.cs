using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour {

    private Rigidbody2D rb2d;

    public int speed = -5;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();

        rb2d.velocity = new Vector2(0, speed);
        rb2d.angularVelocity = Random.Range(-200, 200);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        string name = obj.gameObject.name;

        if (name == "bullet(Clone)")
        {
            Debug.Log(transform.name);
            string enemyName = transform.name;
            GameManager.Score(enemyName);
            Destroy(gameObject);
            Destroy(obj.gameObject);
        }

        if (name == "spaceship")
        {
            string enemyName = transform.name;
            GameManager.adjustHealth(enemyName);
            Destroy(gameObject);
        }
    }

}
