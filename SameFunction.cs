using UnityEngine;
using System.Collections;

public class SameFunction : MonoBehaviour {
	void Start () {
	  
	       print("ye hai meri life");
	       print("jo ki bekar toh nhi hai ");
	       print("par kuch khass bhi  nhi hai");
	       print(tool(45,34));
           print(tool("neha","murder"));
		   }
	     
		  
	  int tool(int kechi ,int chaku) {
		    int first=kechi;
			int second=chaku;
			int final=first+second;
		    return final;
		 }
	  string tool(string pitai , string murder){
	         string f=pitai;
			 string s=murder;
			 string fl=f+s;
		
            return fl; 		
		}
	
	}
