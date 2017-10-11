using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour {

    private Rigidbody2D rb2d;

    public int speed = -5;
    float angle;

    public bool isPowerUp;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();

        angle = Random.Range(-2.0f, 2.0f);

        rb2d.velocity = new Vector2(angle, speed);
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
            if(isPowerUp)
            {
                spaceshipScript.poweredUp = true;
            }

            Destroy(gameObject);
            Destroy(obj.gameObject);
        }
        else if (name == "bullet2(Clone)")
        {
            if (isPowerUp)
            {
                spaceship2Script.poweredUp = true;
            }

            Destroy(gameObject);
            Destroy(obj.gameObject);
        }

        if (name == "spaceship1")
        {
            Destroy(gameObject);
        }
        if (name == "spaceship2")
        {
            Destroy(gameObject);
        }
    }

}
