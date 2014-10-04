using UnityEngine;
using System.Collections;

public class Bala : MonoBehaviour {


	void Start(){

		Invoke ("DestruirBala", 4f);
	
	}

	void Update () {
	
		transform.Translate(new Vector2(5 * Time.deltaTime, 0));
		//ajustar la velocidad, se puede usar AddForce
	}

	void OnTriggerEnter2D(Collider2D objeto){
	
		if(objeto.tag == "Cuervo"){

			DestruirBala ();
				
		}
	
	}

	void DestruirBala(){

		Destroy (gameObject);

	}

}