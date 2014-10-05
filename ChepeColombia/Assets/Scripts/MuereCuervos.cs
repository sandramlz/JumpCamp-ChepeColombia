using UnityEngine;
using System.Collections;

public class MuereCuervos : MonoBehaviour {

	private AnimacionesCuervos animarCuervo;
	private bool muerto;
	private int score;

	void Awake () 
	{
		score = PlayerPrefs.GetInt ("score");
	}

	// Use this for initialization
	void Start () {
	
		animarCuervo = GetComponent<AnimacionesCuervos>();

	}

	void Update(){
		score = PlayerPrefs.GetInt ("score");
		CuervoAlSuelo ();

	}

	void OnTriggerEnter2D(Collider2D objeto){

		//Destroy (gameObject);
		muerto = true;
		score += 5;
		PlayerPrefs.SetInt("score", score);

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