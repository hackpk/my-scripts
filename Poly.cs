using UnityEngine;
using System.Collections;

public class Poly : MonoBehaviour {

      
	  public int toys = 52552;

   public class Pk{
	
	  public void Area(int len,int breadth){
	    
	    print(" i don't know about this area");

	  }
	
	}


   public class Aashi: Pk{


      public void Area(int len,int breadth){

	   int area = len * breadth;
	 
	   print("oke@@@@@@@#######" +area);
	 
	 }  
   } 
   public class Nishu: Pk{
 
       public void Area(int len,int breadth){
         
		  int area = len * breadth;
         print("great bhai!!! i am so dam cool " +area);
  
       }
	 }
   void start()
   {
	 
	    Pk a = new Aashi();
		a.Area(5,7);
	 
   }


}