using UnityEngine;
using System.Collections;

public class Llorona : MonoBehaviour {
	public GameObject dialogo3;
	public GameObject dialogo4;
	private float time = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		dialogo3.gameObject.active = false;
		dialogo4.gameObject.active = false;
		time = time + Time.deltaTime;
	}

	void OnTriggerEnter2D(Collider2D objeto){
		dialogo3.gameObject.active = true;
	}

}
