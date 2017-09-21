using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    static int PlayerScore = 0;
    static int PlayerHealth = 100;

    public GUIStyle guiStyle = new GUIStyle();

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void Score(string enemyName)
    {
        if (enemyName == "enemy(Clone)")
        {
            PlayerScore++;
        }
    }

    public static void adjustHealth(string enemyName)
    {
        if (enemyName == "enemy(Clone)")
        {
            PlayerHealth -= 50;
        }
    }

    public void OnGUI()
    {
        guiStyle.fontSize = 40;
        GUI.Label(new Rect(Screen.width / 2 - 300, 20, 100, 100), "Score: " + PlayerScore, guiStyle);
        GUI.Label(new Rect(Screen.width / 2 + 100, 20, 100, 100), "Health: " + PlayerHealth, guiStyle);

        if (PlayerHealth == 0)
        {
            GUI.Label(new Rect(Screen.width / 2 - 150, 200, 2000, 1000), "GAME OVER", guiStyle);
            spawnScript.AllowSpawn = false;
        }

    }
}
