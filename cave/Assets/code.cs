using UnityEngine;
using System.Collections;

public class code : MonoBehaviour {

	public float raideur = 1.0f;
	public float masse = 1.0f;
	public Vector3 vitesse;
	public float dampling = 0.5f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//1. Force du ressort

		Vector3 position = transform.position;
		Vector3 force = -raideur * position;

		//2. Calcul de l'acceleration

		Vector3 acceleration = force / masse;

		//3. Calcul de la vitesse

		vitesse = vitesse + acceleration * Time.deltaTime;
		vitesse = vitesse * 1.0f /(1.0f + Time.deltaTime * dampling) ;
		// vitesse += acceleration * Time.deltaTime;

		//4. Calcul de la (nouvelle) position
		transform.position = transform.position + vitesse * Time.deltaTime;



	}
}