using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceshipScript : MonoBehaviour {

    private Rigidbody2D rb2d;

    public KeyCode moveUp = KeyCode.W;
    public KeyCode moveDown = KeyCode.S;
    public KeyCode shoot = KeyCode.Space;

    public GameObject bullet;

    public int Player1Health = 100;
    public int Player1Lives = 3;

    public static bool poweredUp = false;
    int shotsLeft = 10;

    // Use this for initialization
    void Start () {

        rb2d = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector2 vel = rb2d.velocity;

        if (Input.GetKey(moveUp))
        {
            vel.y = 10;
        }           
        else if (Input.GetKey(moveDown))
        {
            vel.y = -10;
        }            
        else
        {
            vel.y = 0;
        }
        rb2d.velocity = vel;    

        if( transform.position.y > 4.4f)
        {
            transform.position = new Vector2(transform.position.x, 4.4f);
        }
        else if (transform.position.y < -4.4f)
        {
            transform.position = new Vector2(transform.position.x, -4.4f);
        }

        if (Input.GetKeyDown(shoot))
        {
            if( poweredUp )
            {
                Vector3 pos = transform.position;

                Instantiate(bullet, pos, Quaternion.identity);
                pos.y += 0.25f;
                Instantiate(bullet, pos, Quaternion.identity);
                pos.y -= 0.5f;
                Instantiate(bullet, pos, Quaternion.identity);

                shotsLeft--;
                if(shotsLeft == 0)
                {
                    poweredUp = false;
                    shotsLeft = 10;
                }
            }
            else
            {
                Vector3 pos = transform.position;
                Instantiate(bullet, pos, Quaternion.identity);
            }
        }

    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        string name = obj.gameObject.name;

        if (name == "bullet2(Clone)")
        {
            if(spawnScript.AllowSpawn == false)
            {
                // do nothing
            }
            else
            {
                if ((Player1Health - 5) <= 0)
                {
                    Player1Lives--;
                    Player1Health = 100;
                }
                else
                {
                    Player1Health -= 5;
                }
            }
        
            Destroy(obj.gameObject);
        }
        else if (name == "enemy(Clone)")
        {
            if (spawnScript.AllowSpawn == false)
            {
                // do nothing
            }
            else
            {
                if ((Player1Health - 5) <= 0)
                {
                    Player1Lives--;
                    Player1Health = 100;
                }
                else
                {
                    Player1Health -= 5;
                }
            }

            Destroy(obj.gameObject);
        }
        else if (name == "enemy2(Clone)")
        {
            if (spawnScript.AllowSpawn == false)
            {
                // do nothing
            }
            else
            {
                if ((Player1Health - 5) <= 0)
                {
                    Player1Lives--;
                    Player1Health = 100;
                }
                else
                {
                    Player1Health -= 5;
                }
            }

            Destroy(obj.gameObject);
        }
        else if (name == "enemyPoweredUp(Clone)")
        {
            if (spawnScript.AllowSpawn == false)
            {
                // do nothing
            }
            else
            {
                if ((Player1Health - 5) <= 0)
                {
                    Player1Lives--;
                    Player1Health = 100;
                }
                else
                {
                    Player1Health -= 5;
                }
            }

            Destroy(obj.gameObject);
        }
        else if (name == "enemy2PoweredUp(Clone)")
        {
            if (spawnScript.AllowSpawn == false)
            {
                // do nothing
            }
            else
            {
                if ((Player1Health - 5) <= 0)
                {
                    Player1Lives--;
                    Player1Health = 100;
                }
                else
                {
                    Player1Health -= 5;
                }
            }

            Destroy(obj.gameObject);
        }
    }

    public void ResetValues()
    {
        Player1Health = 100;
        Player1Lives = 3;
    }


}
