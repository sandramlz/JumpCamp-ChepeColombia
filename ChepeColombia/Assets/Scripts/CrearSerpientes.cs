using UnityEngine;
using System.Collections;

public class CrearSerpientes : MonoBehaviour {

	public GameObject [] serpientes;
	private Vector3 posicionSerpiente;
	private float y = -3.3f;


	public void crearSerpiente(){

		posicionSerpiente = new Vector3 (15, y, 1);
		Instantiate(serpientes [Random.Range(0, serpientes.Length)], transform.position + posicionSerpiente, Quaternion.identity);
	
		posicionSerpiente = new Vector3 (20, y, 1);
		Instantiate(serpientes [Random.Range(0, serpientes.Length)], transform.position + posicionSerpiente, Quaternion.identity);

		posicionSerpiente = new Vector3 (25, y, 1);
		Instantiate(serpientes [Random.Range(0, serpientes.Length)], transform.position + posicionSerpiente, Quaternion.identity);
		


	}

}
