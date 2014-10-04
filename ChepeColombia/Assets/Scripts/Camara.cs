using UnityEngine;
using System.Collections;

public class Camara : MonoBehaviour {

	public Transform camaraSigue;
	public float separacion = 6f;

	void Start () {
//		camaraSigue = GameObject.FindGameObjectWithTag ("Player").transform;
	}
	
	void Update () {
//		transform.position = new Vector3(camaraSigue.position.x + 0.5f, transform.position.y, transform.position.z);
		transform.position = new Vector3(camaraSigue.position.x+separacion, transform.position.y, transform.position.z);

	}
}
