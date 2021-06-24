using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swosh : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void suaraSwosh() {
		GameObject.Find("suara swosh").GetComponent<AudioSource>().Play();
	}
	// Update is called once per frame
	void Update () {
		
	}
}
