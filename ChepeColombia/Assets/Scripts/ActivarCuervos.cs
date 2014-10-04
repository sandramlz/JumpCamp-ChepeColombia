using UnityEngine;
using System.Collections;

public class ActivarCuervos : MonoBehaviour {

	private VolarCuervos cuervo;


	void Start () {
		
		cuervo = GetComponent<VolarCuervos> ();
		
	}
	

	void OnTriggerEnter2D(Collider2D objeto){

		cuervo.Volando();
		
	}

}
