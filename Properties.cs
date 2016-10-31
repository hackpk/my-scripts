using UnityEngine;
using System.Collections;

public class Properties : MonoBehaviour {

      public class Bank{
	        private int amount=34558;
	        public int Amount
		    {
			    get{
				  return amount;
				}
				
			}
			public Bank()
			{
			
			  print("khata khul gya");
			
			}
	  
	  
	 }


	 void Start () {
	
	      Bank a= new Bank();
          print(a.Amount);

	 }
	
	
}
