using UnityEngine;
using System.Collections;

public class MoverSerpientes : MonoBehaviour {


	void Start () {
	
		transform.eulerAngles = new Vector2(0, 180);

	}
	

	void Update(){
		
		transform.Translate(new Vector2(1 * Time.deltaTime, 0));
		
	}

}
