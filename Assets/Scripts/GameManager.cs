using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public GUIStyle guiStyle = new GUIStyle();

    private spaceshipScript spaceship;
    private spaceship2Script spaceship2;
    //private spawnScript spawner;
    //private spawnScript spawner2;

    public static bool showLabel = true;

    public KeyCode restart = KeyCode.R;

    // Use this for initialization
    void Start () {
        spaceship = GameObject.FindGameObjectWithTag("Player1").GetComponent<spaceshipScript>();
        spaceship2 = GameObject.FindGameObjectWithTag("Player2").GetComponent<spaceship2Script>();
        //spawner = GameObject.FindGameObjectWithTag("spawner").GetComponent<spawnScript>();
        //spawner2 = GameObject.FindGameObjectWithTag("spawner2").GetComponent<spawnScript>();
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(restart))
        {
            SceneManager.LoadScene("MainScene");
        }

    }

    public void OnGUI()
    {
        guiStyle.fontSize = 30;

        if (spaceship.Player1Lives == 0)
        {
            showLabel = true;
            if (showLabel)
            {
                GUI.Label(new Rect(Screen.width / 2 - 200, 200, 2000, 1000), "GAME OVER, PLAYER 2 WINS!", guiStyle);
                GUI.Label(new Rect(Screen.width / 2 - 200, 300, 2000, 1000), "Press R to restart and play again!", guiStyle);
                spawnScript.AllowSpawn = false;
                spawn2Script.AllowSpawn = false;
            }
        }
        else if (spaceship2.Player2Lives == 0)
        {
            showLabel = true;
            if (showLabel)
            {
                GUI.Label(new Rect(Screen.width / 2 - 200, 200, 2000, 1000), "GAME OVER, PLAYER 1 WINS!", guiStyle);
                GUI.Label(new Rect(Screen.width / 2 - 200, 300, 2000, 1000), "Press R to restart!", guiStyle);
                spawnScript.AllowSpawn = false;
                spawn2Script.AllowSpawn = false;
            }
        }

    }
}
