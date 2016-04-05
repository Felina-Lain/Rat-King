using UnityEngine;
using System.Collections;

public class code2 : MonoBehaviour {

	//bouger la caméra sur la souris
	//smooth camera

	private Vector3 target;

	// Use this for initialization
	void Start () {
		target = Vector3.zero;
		target.z = transform.position.z;

	}

	// Update is called once per frame
	void Update () {
		float mouseX = Input.GetAxis("Mouse X");
		float mouseY = Input.GetAxis("Mouse Y");

		target.x = target.x + mouseX;
		//target.x += mouseX;
		target.y += mouseY;


		transform.position = Vector3.Lerp (transform.position, target, 0.1f);
		//if (Mathf.Abs(mouseX) > 0.001f);
		//transform.Translate (mouseX, mouseY, 0f);

	}
}