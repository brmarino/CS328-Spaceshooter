using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceshipScript : MonoBehaviour {

    private Rigidbody2D rb2d;

    public KeyCode moveLeft = KeyCode.A;
    public KeyCode moveRight = KeyCode.D;
    public KeyCode shoot = KeyCode.Space;

    public GameObject bullet;

    // Use this for initialization
    void Start () {

        rb2d = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {

        var vel = rb2d.velocity;

        if (Input.GetKey(moveLeft))
        {
            vel.x = -10;
        }           
        else if (Input.GetKey(moveRight))
        {
            vel.x = 10;
        }            
        else
        {
            vel.x = 0;
        }
        rb2d.velocity = vel;    

        if (Input.GetKeyDown(shoot))
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
        }

    }
}
