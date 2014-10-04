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
		if((enSuelo || !dobleSalto) && Input.GetKey (KeyCode.UpArrow)){

			rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x+0.5f, fuerzaSalto);

			if(!dobleSalto && !enSuelo){
				dobleSalto = true;
			}
		}
		if (enSuelo  && Input.GetKey (KeyCode.RightArrow)) 
		{
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