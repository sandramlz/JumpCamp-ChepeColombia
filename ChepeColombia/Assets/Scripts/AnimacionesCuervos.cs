using UnityEngine;
using System.Collections;

public class AnimacionesCuervos : MonoBehaviour {

	private Animator animacionCuervo;
	private bool volar;

	void Start () {
	
		animacionCuervo = GetComponent<Animator> ();

	}
	

	void Update(){

		CuervoAlAtque ();

	}


	public void Volar(){

		animacionCuervo.SetBool ("quieto", false);
		volar = true;
		Invoke ("CuervoEnElArbol", 5f);
	}


	public void Muere(){
	
		animacionCuervo.SetTrigger ("muerto");
		Invoke ("DestruirCuervo", 5f);

	}

	void CuervoAlAtque (){

		if (volar) {

			transform.Translate(new Vector2(-5f * Time.deltaTime, -1 * Time.deltaTime));
			Debug.Log ("Estoy volando");

		} else {

			Debug.Log ("Estoy en el arbol");

		}

	}

	void CuervoEnElArbol(){

		volar = false;
		DestruirCuervo ();

	}

	void DestruirCuervo(){

		Destroy (gameObject);

	}

}
