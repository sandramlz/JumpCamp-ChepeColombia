using UnityEngine;
using System.Collections;

public class Creditos : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		
		Debug.Log("Cargar creditos");
		Application.LoadLevel("Creditos");
		
	}
}
