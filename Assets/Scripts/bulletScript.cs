﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour {

    private Rigidbody2D rb2d;

    public int speed = 6;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();

        rb2d.velocity = new Vector2(0, speed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
