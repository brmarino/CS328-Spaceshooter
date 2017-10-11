using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class livesScript : MonoBehaviour {

    public Sprite[] livesSprites;

    public Image livesImage1;
    public Image livesImage2;

    private spaceshipScript spaceship;
    private spaceship2Script spaceship2;

    // Use this for initialization
    void Start() {
        spaceship = GameObject.FindGameObjectWithTag("Player1").GetComponent<spaceshipScript>();
        spaceship2 = GameObject.FindGameObjectWithTag("Player2").GetComponent<spaceship2Script>();
    }

    // Update is called once per frame
    void Update() {
        livesImage1.sprite = livesSprites[spaceship.Player1Lives];
        livesImage2.sprite = livesSprites[spaceship2.Player2Lives];
    }

}
