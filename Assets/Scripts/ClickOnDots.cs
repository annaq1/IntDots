using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnDots : MonoBehaviour {


    //Destroy GameObject if you click the mouse on it
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("COLLISION");
        Destroy(gameObject);
    }

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

    }
}
