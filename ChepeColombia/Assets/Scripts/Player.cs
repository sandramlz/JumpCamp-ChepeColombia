using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Variables relacionadas con salto
	public float fuerzaSalto = 100f;
	public float velocidad = 10f;
	private float velocidadx;
	private bool enSuelo = true;
	public Transform comprobadorSuelo;
	private float comprobadorRadio = 0.5f;
	public LayerMask mascaraSuelo;
	private bool dobleSalto = false;
	
	// Variables relacionadas con animaciones
	private Animator animator;
	private bool Oprime=true;
	private bool corre=false;
	private bool Dispara=false;

	// Variables relacionadas con el disparo
	public GameObject Bala;
	private Vector3 PosicionBala;
	private float BalaEnX;
	private float BalaEnY;

	public GameObject dialogo;
	public GameObject dialogo2;
	public GameObject dialogo3;
	public GameObject dialogo4;
	public GameObject Llorona1;
	public GameObject dialogo5;
	public GameObject dialogo6;
	public GameObject dialogo7;
	public GameObject dialogo8;
	public GameObject Llorona;
	public GameObject Aventurero;
	private float time = 0;



	void Awake(){
		animator = GetComponent<Animator>();
	}
	
	// Use this for initialization
	void Start () {

	}
	
	void FixedUpdate(){

		enSuelo = Physics2D.OverlapCircle(comprobadorSuelo.position, comprobadorRadio, mascaraSuelo);
		animator.SetBool("isGrounded", enSuelo);
		if(enSuelo){
			dobleSalto = false;
		}


	}
	
	// Update is called once per frame
	void Update () {

		// Dialogo inicial
		Destroy (dialogo.gameObject, 3.0f);
		dialogo2.gameObject.active = false;
		dialogo3.gameObject.active = false;
		dialogo4.gameObject.active = false;
		Llorona1.gameObject.active = false;
		dialogo5.gameObject.active = false;
		dialogo6.gameObject.active = false;
		dialogo7.gameObject.active = false;
		dialogo8.gameObject.active = false;

		if (time < 3.1f) {
						time = time + Time.deltaTime;
				} else if (time >= 3.1f && time < 6.1f) {
						dialogo2.gameObject.active = true;
						time = time + Time.deltaTime;
				} else if (time > 6.1f) {
						time = time + Time.deltaTime;
						dialogo2.gameObject.active = false;
				}

		// Dialogo con llorona
		float distanciaX = -(transform.position.x - Llorona.transform.position.x);

		if (distanciaX < 6.5f && distanciaX > 6.0f) 
		{
			dialogo3.gameObject.active = true;
		}

		else if (distanciaX < 6.0f && distanciaX > 2.0f) {
			dialogo3.gameObject.active = false;
			dialogo4.gameObject.active = true;
			Llorona1.gameObject.active = true;
		}
		else if (distanciaX < 2.0f && distanciaX > 0.0f) {
			dialogo4.gameObject.active = false;
			Llorona1.gameObject.active = false;
			dialogo5.gameObject.active = true;
				}
		else if (distanciaX < 0.0f && distanciaX > -1.0f){
			dialogo5.gameObject.active = false;
			dialogo6.gameObject.active = true;
		}

		else if (distanciaX < -3.0f && distanciaX > -3.5f){
			dialogo6.gameObject.active = false;
			dialogo7.gameObject.active = true;
		}
		else if (distanciaX < -3.5f && distanciaX > -5.5f){
			dialogo7.gameObject.active = false;
			dialogo8.gameObject.active = true;
		}
		// Movimiento, salto y disparo
		if((enSuelo || !dobleSalto) && Input.GetKey (KeyCode.UpArrow)){

			rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x+1f, fuerzaSalto);

			//GameObject soundController = GameObject.Find("SaltoSoundController");
			//soundController.SendMessage("SaltoSound");

			if(!dobleSalto && !enSuelo){
				dobleSalto = true;
			}
		}
		if (enSuelo  && Input.GetKey (KeyCode.RightArrow)) 
		{
			GameObject pasossoundController = GameObject.Find("PasosSoundController");
			pasossoundController.SendMessage("PasosSound");

			transform.Translate(new Vector3(velocidad * 5f * Time.deltaTime,0,0));
			enSuelo=true;
			animator.SetBool("isGrounded", enSuelo);
			corre=true;
			animator.SetBool("Corre", corre);
			Oprime=true;
			animator.SetBool("Flecha", Oprime);
			Dispara=false;
			animator.SetBool("Disparar", Dispara);

		}

		if (enSuelo && Input.GetKey (KeyCode.LeftArrow)) 
		{
			GameObject pasossoundController = GameObject.Find("PasosSoundController");
			pasossoundController.SendMessage("PasosSound");

			transform.Translate(new Vector3(-velocidad * Time.deltaTime,0,0));
			enSuelo=true;
			animator.SetBool("isGrounded", enSuelo);
			corre=true;
			animator.SetBool("Corre", corre);
			Oprime=true;
			animator.SetBool("Flecha", Oprime);
			Dispara=false;
			animator.SetBool("Disparar", Dispara);


		}

		if (Input.GetKeyDown (KeyCode.Space)/*Input.anyKeyDown (KeyCode.Space)*/){
			Dispara=true;
			animator.SetBool("Disparar", Dispara);
			BalaEnX = 0f;
			BalaEnY = 0.4f;
			PosicionBala = new Vector3 (BalaEnX, BalaEnY, 0);
			Instantiate(Bala, transform.position + PosicionBala, Quaternion.identity);
			corre=true;
			animator.SetBool("Corre", corre);
			
		}

		else if (!Input.anyKey){
			corre=false;
			animator.SetBool("Corre", corre);

		}


	}
}