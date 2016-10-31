using UnityEngine;
using System.Collections;

public class MyRealGene{
     
	 public struct Double{
	   public int x;
	   public int y;
	 }

     public int Sum(int a,int b)
	 {
	 
	 
	    return a+b;
	 
	 }
	 public string Sum(string a,string b)
	 {
	 
	 
	   return a+b;
	 }
	 public float Sum(float a,float b)
	 {
	 
	  return a+b;
	 
	 }
	  
     public Double Swap<T>(ref T a,ref T b)
	 {
	       T temp;
	       temp = b;
	       b = a;
	       a = b;

	       Double dd;
           dd.x = a;
	       dd.y = b;

	       return dd;
	  }
}

public class Gene<T>
{
   T field = 9;
   public T Printing(T a)
   {
   
     field =a ;
	 return field;
   
   }


}
