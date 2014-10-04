using UnityEngine;
using System.Collections;

public class VenenoSerpientes : MonoBehaviour {

	private GameObject Aventurero;


	void Start () {
	
		Aventurero = GameObject.Find ("Aventurero");

	}


	void OnCollisionEnter2D(Collision2D objeto){

		Aventurero.SendMessage ("MuereAventurero");
	
	}

}
