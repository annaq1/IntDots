using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private float playerSpeed = 5; //Give player some speed so its not slow af

    void MovePlayer()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("UP");
            transform.Translate(0, playerSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("DOWN");
            transform.Translate(0, -playerSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("LEFT");
            transform.Translate(-playerSpeed * Time.deltaTime, 0 ,0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("RIGHT");
            transform.Translate(playerSpeed * Time.deltaTime, 0, 0);
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        MovePlayer();
		
	}
}
