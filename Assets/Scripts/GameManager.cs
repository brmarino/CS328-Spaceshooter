using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public GUIStyle guiStyle = new GUIStyle();

    private spaceshipScript spaceship;
    private spaceship2Script spaceship2;

    public static bool showLabel = true;

    public KeyCode restart = KeyCode.R;
    public KeyCode quit = KeyCode.Escape;

    // Use this for initialization
    void Start () {
        spaceship = GameObject.FindGameObjectWithTag("Player1").GetComponent<spaceshipScript>();
        spaceship2 = GameObject.FindGameObjectWithTag("Player2").GetComponent<spaceship2Script>();
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(restart))
        {
            SceneManager.LoadScene("MainScene");
        }
        else if(Input.GetKey(quit))
        {
            Application.Quit();
        }

    }

    public void OnGUI()
    {
        guiStyle.fontSize = 30;
        guiStyle.normal.textColor = Color.white;

        if (spaceship.Player1Lives == 0)
        {
            showLabel = true;
            if (showLabel)
            {
                guiStyle.normal.textColor = Color.green;
                GUI.Label(new Rect(Screen.width / 2 - 200, 100, 2000, 1000), "GAME OVER, PLAYER 2 WINS!", guiStyle);
                GUI.Label(new Rect(Screen.width / 2 - 200, 150, 2000, 1000), "Press R to restart and play again!", guiStyle);
                spawnScript.AllowSpawn = false;
                spawn2Script.AllowSpawn = false;

                guiStyle.normal.textColor = Color.white;
                GUI.Label(new Rect(Screen.width / 2 - 200, 450, 2000, 1000), "Or press 'ESC' to quit the game!", guiStyle);
            }
        }
        else if (spaceship2.Player2Lives == 0)
        {
            showLabel = true;
            if (showLabel)
            {
                guiStyle.normal.textColor = Color.red;
                GUI.Label(new Rect(Screen.width / 2 - 200, 100, 2000, 1000), "GAME OVER, PLAYER 1 WINS!", guiStyle);
                GUI.Label(new Rect(Screen.width / 2 - 200, 150, 2000, 1000), "Press R to restart and play again!", guiStyle);
                spawnScript.AllowSpawn = false;
                spawn2Script.AllowSpawn = false;

                guiStyle.normal.textColor = Color.white;
                GUI.Label(new Rect(Screen.width / 2 - 200, 450, 2000, 1000), "Or press 'ESC' to quit the game!", guiStyle);
            }
        }
    }
}
