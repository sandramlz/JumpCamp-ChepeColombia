using UnityEngine;
using System.Collections;

public class SaludPlayer : MonoBehaviour {

	public int vidasmax;
	private int score;
	private int vidasperdidas;
	public TextMesh scoreText;
	public TextMesh LifesText;

	public GameObject vidasuno;
	public GameObject vidasdos;
	public GameObject vidastres;



	void Awake () 
	{
		vidasperdidas=PlayerPrefs.GetInt("vidasperdidas");

		if (vidasperdidas == 1) {
			Destroy (vidastres);
				}
		if (vidasperdidas == 2) {
			Destroy (vidastres);
			Destroy (vidasdos);
		}
		if (vidasperdidas == 3) {
			Destroy (vidastres);
			Destroy (vidasdos);
			Destroy (vidasuno);
		}

	}


	public void MuereAventurero()
	{
		vidasperdidas = vidasperdidas + 1;
		PlayerPrefs.SetInt("vidasperdidas", vidasperdidas);
		Debug.Log(vidasperdidas);

			Destroy (this.gameObject);
			Reiniciar ();

		if (vidasperdidas>vidasmax) 
		{
			TerminarJuego ();
		}
	}
	
	public void TerminarJuego (){
		Debug.Log("Game Over");
		Application.LoadLevel("MainWindow");	}

	void Reiniciar(){
		Debug.Log(vidasperdidas);
		Application.LoadLevel ("Nivel1");
	}
}
