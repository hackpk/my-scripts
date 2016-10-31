using UnityEngine;
using System.Collections;

public class Classes : MonoBehaviour {


   public class Vehicle{
            
         private static int ferrari = 4567;
		 private int sN;
		 public  Vehicle ()
		  {
		  
       		  ferrari++;
		      print("No. on ferrai is " + ferrari);
              
		  } 
		  public void ChangeNumber(int newNumber){
		  
		  sN = newNumber;
		  
		  }
		    
	}	    
	void Start () {
	       
		   Vehicle an = new Vehicle();
		   Vehicle ann = new Vehicle();
		   ann.ChangeNumber(1);
	}
	
	
}
