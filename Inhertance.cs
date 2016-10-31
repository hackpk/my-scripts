using UnityEngine;
using System.Collections;

public class Inhertance : MonoBehaviour {

	
	void Start () {
	
	            Beta chota = new Beta();
             

				Papa chote = new Papa();
				Papa bade = new Papa();


			print("chote wale " +chote.salary);
			print("bade wale " +bade.salary);

			bade.SalaryInc();
			print("bade wale " +bade.salary);
	}
}
