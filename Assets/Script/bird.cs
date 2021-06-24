using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour {
	public float berat;
	public GameObject gameOver, skor, Emas, Perak;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "grid") {
			GameObject.Find("suara jatuh").GetComponent<AudioSource>().Play();
			skor.SetActive (false);
			gameOver.SetActive (true);
			if (PlayerPrefs.GetInt ("hightSkor") < skor.GetComponent<skor> ().score){
				PlayerPrefs.SetInt ("hightSkor", skor.GetComponent<skor> ().score);
			}

			if (skor.GetComponent<skor> ().score > 50) {
				Emas.SetActive (true);
			} else if (skor.GetComponent<skor> ().score > 20) {
				Perak.SetActive (true);
			}
			Time.timeScale = 0;
		}

		if (other.gameObject.name == "addScore") {
			bird.GetComponent<Rigidbody2D>.gravityScale = berat;
		}

		if (other.gameObject.name == "addScore") {
			GameObject.Find("suara skor").GetComponent<AudioSource>().Play();
			skor.GetComponent<skor> ().score++;
		}
	}
		
}
