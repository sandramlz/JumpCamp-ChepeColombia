using UnityEngine;
using System.Collections;

public class MuereSerpientes : MonoBehaviour {
	private int score;

	void Awake () 
	{
		score = PlayerPrefs.GetInt ("score");
	}
	void Update () {
		score = PlayerPrefs.GetInt ("score");
	}

	void OnCollisionEnter2D(Collision2D objeto){

		Destroy (gameObject);
		score += 3;
		PlayerPrefs.SetInt("score", score);

	}

}
