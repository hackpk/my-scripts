using UnityEngine;
using System.Collections;

public class Balls : MonoBehaviour {

	 public Rigidbody projectile;
	 public int throwPower;
	 void Start()
	 {
	 
	    projectile = projectile.GetComponent<Rigidbody>();
	 }
	 void Update(){
	    if(Input.GetButtonDown("Fire1")){
	      Rigidbody clone;
		  clone = Instantiate(projectile,transform.position,transform.rotation) as Rigidbody;
		  clone.velocity = transform.TransformDirection(Vector3.down * throwPower);
	   
	    }
	 }
}
