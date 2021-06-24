using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeCopy : MonoBehaviour {
	public GameObject pipe, pipeRed, skor, background, backgroundNight, backgroundSiang;
	// Use this for initialization
	void Start () {
		
	}
	void copy () {
		if (skor.GetComponent<skor> ().score < 50) {
			Instantiate (pipe, transform.position, transform.rotation);
		} else if(skor.GetComponent<skor> ().score >= 50) {
			background.SetActive (false);
			backgroundNight.SetActive (true);
			Instantiate (pipeRed, transform.position, transform.rotation);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
