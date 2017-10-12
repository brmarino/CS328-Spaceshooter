using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionScript : MonoBehaviour {

    public KeyCode continueToGame = KeyCode.Space;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(continueToGame))
        {
            SceneManager.LoadScene("MainScene");
        }

    }
}
