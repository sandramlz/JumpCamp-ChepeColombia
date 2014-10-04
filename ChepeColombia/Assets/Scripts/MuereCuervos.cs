using UnityEngine;
using System.Collections;

public class MuereCuervos : MonoBehaviour {

	private AnimacionesCuervos animarCuervo;
	private bool muerto;

	// Use this for initialization
	void Start () {
	
		animarCuervo = GetComponent<AnimacionesCuervos>();

	}

	void Update(){
	
		CuervoAlSuelo ();

	}

	void OnTriggerEnter2D(Collider2D objeto){

		//Destroy (gameObject);
		muerto = true;
		animarCuervo.Muere ();

	}

	void CuervoAlSuelo(){

		if(muerto){

			transform.Translate(new Vector2(0, -5 * Time.deltaTime));

		}else{

			Debug.Log("esta vivo");
		
		}

	}

}