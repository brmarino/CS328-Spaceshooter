using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceship2Script : MonoBehaviour {

    private Rigidbody2D rb2d;

    public KeyCode moveUp = KeyCode.UpArrow;
    public KeyCode moveDown = KeyCode.DownArrow;
    public KeyCode shoot = KeyCode.Keypad0;

    public GameObject bullet;

    public int Player2Health = 100;
    public int Player2Lives = 3;

    public static bool poweredUp = false;
    int shotsLeft = 10;

    // Use this for initialization
    void Start() {

        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {

        var vel = rb2d.velocity;

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

        if (transform.position.y > 4.4f)
        {
            transform.position = new Vector2(transform.position.x, 4.4f);
        }
        else if (transform.position.y < -4.4f)
        {
            transform.position = new Vector2(transform.position.x, -4.4f);
        }

        if (Input.GetKeyDown(shoot))
        {
            if (poweredUp)
            {
                Vector3 pos = transform.position;

                Instantiate(bullet, pos, Quaternion.identity);
                pos.y += 0.25f;
                Instantiate(bullet, pos, Quaternion.identity);
                pos.y -= 0.5f;
                Instantiate(bullet, pos, Quaternion.identity);

                shotsLeft--;
                if (shotsLeft == 0)
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

        if (name == "bullet(Clone)")
        {
            if (spawnScript.AllowSpawn == false)
            {
                // do nothing
            }
            else
            {
                if ((Player2Health - 5) <= 0)
                {
                    Player2Lives--;

                    //if (Player2Lives == 0)
                    //{
                    //    Player2Health = 0;
                    //}
                    //else
                    //{
                        Player2Health = 100;
                    //}
                }
                else
                {
                    Player2Health -= 5;
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
                if ((Player2Health - 5) <= 0)
                {
                    Player2Lives--;
                    Player2Health = 100;
                }
                else
                {
                    Player2Health -= 5;
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
                if ((Player2Health - 5) <= 0)
                {
                    Player2Lives--;
                    Player2Health = 100;
                }
                else
                {
                    Player2Health -= 5;
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
                if ((Player2Health - 5) <= 0)
                {
                    Player2Lives--;
                    Player2Health = 100;
                }
                else
                {
                    Player2Health -= 5;
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
                if ((Player2Health - 5) <= 0)
                {
                    Player2Lives--;
                    Player2Health = 100;
                }
                else
                {
                    Player2Health -= 5;
                }
            }

            Destroy(obj.gameObject);
        }
    }

    public void ResetValues()
    {
        Player2Health = 100;
        Player2Lives = 3;
    }


}
