using UnityEngine;
using System.Collections;

public class torchon : MonoBehaviour {

	public Light genLight;
	public Light torchlight;
	public Light torchlight2;
	public bool torchon1;
	public bool torchon2;
	public AudioSource click;

	void Start (){

		if (genLight.enabled) {
		
			genLight.enabled = false;
		
		}

	}

	// Update is called once per frame
	void Update () {


		if (Input.GetMouseButtonDown (0)) {
		
			torchon1 =! torchon1;
			torchon2 =! torchon2;
			click.Play ();

			if (torchon1 && torchon2) {
			
				torchon2 =! torchon2;
			
			}
		
		
		}

		if (torchon1) {
			torchlight.enabled = true;
		} else {
			torchlight.enabled = false;
		}

		if (torchon2) {			
			torchlight2.enabled = true;
		} else {
			torchlight2.enabled = false;
		}

		if (Input.GetKeyDown (KeyCode.F)) {
		
			torchon1 = false;
			torchon2 = false;
		}

	}
}
