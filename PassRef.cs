using UnityEngine;
using System.Collections;

public class PassRef : MonoBehaviour {

	
	void Start () {
	         
         int boyAge = 24;
		 string boyName = "Dharmpal";

		 int girlAge=20;
		 string girlName = "sangeeta";

	     Boyage(ref boyAge,ref boyName);
		 Girlage(ref girlAge, ref girlName);

		 print(" boy age is " + boyAge +" girl age is " +girlAge);
	}


	void Boyage(ref int age,ref string name)
	{
	  age+=5;
	  print(" Now after 5 yearsboy age is  " + age);
	  print("name is " +name);

	}
	void Girlage(ref int age,ref string name)
	{
	  age+=1;
	  print(" Now after 5 years girl age is " + age);
	
	}
	
}
