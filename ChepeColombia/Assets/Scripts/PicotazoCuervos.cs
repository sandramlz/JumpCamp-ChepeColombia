using UnityEngine;
using System.Collections;

public class PicotazoCuervos : MonoBehaviour {


	private GameObject Aventurero;
	
	
	void Start () {
		
		Aventurero = GameObject.Find ("Aventurero");
		
	}

	
	void OnCollisionEnter2D(Collision2D objeto){
		Debug.Log ("Picotazo");
		Aventurero.SendMessage ("MuereAventurero");
		
	}


}
