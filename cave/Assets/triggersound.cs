using UnityEngine;
using System.Collections;

public class triggersound : MonoBehaviour {

	public AudioSource splash;


	// Update is called once per frame
	void OnTriggerEnter () {
	
		splash.Play();

	}
	void OnTriggerExit () {

		splash.Stop();

	}
}
