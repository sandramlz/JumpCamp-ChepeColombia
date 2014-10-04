using UnityEngine;
using System.Collections;

public class VolarCuervos : MonoBehaviour {
	
	private GameObject animarCuervo;

	void Start () {

		animarCuervo = GameObject.FindGameObjectWithTag ("Cuervo");

	}
	

	public void Volando(){

		animarCuervo.SendMessage ("Volar");

	}

}
