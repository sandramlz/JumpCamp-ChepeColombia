using UnityEngine;
using System.Collections;

public class CrearCuervos : MonoBehaviour {
	
	public GameObject [] cuervos;
	private Vector3 posicionCuervo;
	private float y = 5f;
	
	
	public void crearCuervo(){
		
		posicionCuervo = new Vector3 (0, y, 1);
		Instantiate(cuervos [Random.Range(0, cuervos.Length)], transform.position + posicionCuervo, Quaternion.identity);

	}
	
}
