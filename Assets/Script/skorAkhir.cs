using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skorAkhir : MonoBehaviour {
	public GameObject skor;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.name == "skor akhir") {
			GetComponent<Text> ().text = skor.GetComponent<skor> ().score.ToString ();
		} else if (gameObject.name == "hightSkor") {
			GetComponent<Text> ().text = PlayerPrefs.GetInt ("hightSkor").ToString ();
		}
	}
}
