using UnityEngine;
using System.Collections;

public class zqlksound : MonoBehaviour {

	public float storage;
	public AudioSource walk;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		storage = this.transform.position.x;

		if (storage > this.transform.position.x || storage < this.transform.position.x ) {
		
			walk.Play ();
		
		}


	}
}
