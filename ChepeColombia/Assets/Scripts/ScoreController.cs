using UnityEngine;
using System.Collections;

public class ScoreController : MonoBehaviour {

	private int score;

	void Awake () 
	{
		score = PlayerPrefs.GetInt ("score");
	}
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		score = PlayerPrefs.GetInt ("score");
	}

	void OnGUI() {
		GUI.Label (new Rect (800,20,250,250), "Puntaje: " + 	score.ToString ());
		GUIStyle style = GUI.skin.GetStyle ("label");
		style.fontSize = (int)(30.0f);
		style.normal.textColor = Color.black;
		GUI.color = Color.yellow;

	}
}