using UnityEngine;
using System.Collections;

public class Disparar : MonoBehaviour {

	public GameObject bulletObject;
	public float bulletForce;
	
	private GameObject clonedBulletObject;
	
	void Update ( ) {
		
		if ( Time.timeScale != 0){
			if ( Input.GetMouseButtonDown ( 0 ) ) {
			
				clonedBulletObject = (GameObject)Instantiate ( bulletObject ,
					transform.position ,
					transform.rotation );
			
				clonedBulletObject.GetComponent<Rigidbody>().AddRelativeForce ( 
					0 , 0 , bulletForce , ForceMode.Impulse );
			
				
			}
		}
	
	}
}