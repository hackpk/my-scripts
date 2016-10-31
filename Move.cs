using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	

	
	void Update () {
	       int var=3;
	       if(Input.GetKey(KeyCode.UpArrow)){
		   
		       transform.Translate(Vector3.left* var * Time.deltaTime);
		   }

           if(Input.GetKey(KeyCode.DownArrow))
		   {
		   
		      transform.Translate(Vector3.right*var*Time.deltaTime);
		   }
		   if(Input.GetKey(KeyCode.LeftArrow))
		   {
		   
		      transform.Translate(Vector3.back*var*Time.deltaTime);
		   }
		   if(Input.GetKey(KeyCode.RightArrow))
		   {
		   
		      transform.Translate(Vector3.forward*var*Time.deltaTime);
		   }
		}
}		  