using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthScript : MonoBehaviour {

    public Text player1Health;
    public Text player2Health;

    private spaceshipScript spaceship;
    private spaceship2Script spaceship2;

    // Use this for initialization
    void Start () {
        spaceship = GameObject.FindGameObjectWithTag("Player1").GetComponent<spaceshipScript>();
        spaceship2 = GameObject.FindGameObjectWithTag("Player2").GetComponent<spaceship2Script>();
    }
	
	// Update is called once per frame
	void Update () {
        player1Health.text = "Health: " + spaceship.Player1Health.ToString();
        player2Health.text = "Health: " + spaceship2.Player2Health.ToString();
    }
}
