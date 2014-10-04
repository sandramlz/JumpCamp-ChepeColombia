using UnityEngine;
using System.Collections;

public class AtaqueSerpientes : MonoBehaviour {

	private SaludPlayer salud;

	void Start () {

		salud = GameObject.FindGameObjectWithTag("Player").GetComponent<SaludPlayer> ();
		
	}

	void OnTriggerEnter2D(Collider2D Aventurero){

		salud.MuereAventurero ();

	}

}
