using UnityEngine;
using System.Collections;

public class CafeController : MonoBehaviour {
	public GameObject cafebonus;
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

	void OnTriggerEnter2D(Collider2D col)
	{
		score += 3;
		PlayerPrefs.SetInt("score", score);
		Destroy(this.gameObject);
		Debug.Log(score);

	}
}
