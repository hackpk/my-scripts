using UnityEngine;
using System.Collections;

public class Papa : MonoBehaviour {

	public int salary = 57654;
	protected int jaydat = 55486484;

	public Papa(){
	
	  print("Thik hai!!!!");
	}
	public void SalaryInc(){
	
	   this.salary++;
	
	}



}
public class Beta : Papa{

     public Beta(){
	      int field ;
		  field = jaydat;
		  print(field);
	    print("Blah BLAH blah!!!!!!");
	   
	 }
	


}
