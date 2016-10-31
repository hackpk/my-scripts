using UnityEngine;
using System.Collections;

public class Disco : MonoBehaviour {
     
	 Color[] colors = {Color.red,Color.yellow,Color.green};
	Light discoLight;
	void Start () {
	    discoLight=GetComponent<Light>();
		print(discoLight);
	}
	
	void Update () {
	  int variable = Random.Range(0,3);
	  int sar=Random.Range(0,9);
	  discoLight.color = colors[variable];  
	  discoLight.intensity = sar; 

	}
}
