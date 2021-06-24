using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyPipe : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.name == "pipe" ) {
			Destroy (other.gameObject.transform.parent.gameObject);
		} else if (other.gameObject.name == "pipeRed" ) {
			Destroy (other.gameObject.transform.parent.gameObject);
		}
	}
}
