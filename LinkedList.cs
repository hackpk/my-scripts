using UnityEngine;
using System.Collections;

public class LinkedList : MonoBehaviour {
          
	    public class LinkedFile{
		
		      public int value;
			  public string nameOfFolder;
			  public LinkedFile parentFolder;
			  public LinkedFile childFolder;

              
		
		}

        public LinkedFile root = new LinkedFile();
		public LinkedFile cf = new LinkedFile();
		public LinkedFile ccf = new LinkedFile();

	void Start () { 


	        root.value=3434434;
			root.nameOfFolder = "raabdi";

			print(root.value);
			print(root.nameOfFolder);
			root.childFolder = cf;
			cf.nameOfFolder="choti raabdii #";
			print(root.childFolder.nameOfFolder);
			cf.childFolder = ccf;
			ccf.nameOfFolder = "sabse choti rabbdi";
			print(cf.childFolder.nameOfFolder);
	      
		    ;


	}
	
	
}
