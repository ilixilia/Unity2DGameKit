using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketInteract : MonoBehaviour {

    public GameObject currentInterObj = null;


	// Use this for initialization
	void OnTriggerEnter2D (Collider2D other) {

        if (other.CompareTag("interObject"))
        {
            Debug.Log(other.name);
            currentInterObj = other.gameObject;



        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
