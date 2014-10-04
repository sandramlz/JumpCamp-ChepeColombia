using UnityEngine;
using System.Collections;

public class ActivarSerpientes : MonoBehaviour {

	private CrearSerpientes serpiente;

	
	void Start () {

		serpiente = GetComponent<CrearSerpientes> ();

	}


	void OnTriggerEnter2D(Collider2D objeto){
	
		serpiente.crearSerpiente();
	
	}

}