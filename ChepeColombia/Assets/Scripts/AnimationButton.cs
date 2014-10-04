using UnityEngine;
using System.Collections;

public class AnimationButton : MonoBehaviour {

	private int vidasperdidas;
	private int score;
	void Awake () 
	{
		vidasperdidas=PlayerPrefs.GetInt("vidasperdidas");
		score = PlayerPrefs.GetInt ("score");
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {

		//Presiona=true;
		//animator.SetBool("isPress", Presiona);
		PlayerPrefs.SetInt("score", 0);
		PlayerPrefs.SetInt("vidasperdidas", 0);
		Debug.Log("Cargar nivel");
		Application.LoadLevel("Nivel1");

	}
}
