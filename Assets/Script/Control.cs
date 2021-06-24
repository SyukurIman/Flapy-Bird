using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {
	public float berat, tinggiLoncat;
	public GameObject bird, instructions, pipeCopy, skor;
	// Use this for initialization
	void Start () {
		
	}

	void OnMouseDown(){
		if (Time.timeScale == 1) {
			GameObject.Find ("suara wing").GetComponent<AudioSource> ().Play ();
			pipeCopy.SetActive (true);
			skor.SetActive (true);
			instructions.SetActive (false);
			bird.GetComponent<Rigidbody2D> ().gravityScale = berat;
			bird.GetComponent<Rigidbody2D> ().velocity = new Vector2 (bird.GetComponent<Rigidbody2D> ().velocity.x, tinggiLoncat);
		}
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}
	}
}
