using UnityEngine;
using System.Collections;


public class GrowthTest : MonoBehaviour {

	//added if else functions after trees to see if houses scale
	//GameObject childObject = Instantiate(YourObject) as GameObject;
	//childObject.transform.parent = parentObject.transform

	//Raycastwouldbesomuchfancier
	public GameObject Player1Tree;
	public GameObject Player1House;
	//public GameObject Player1Mountain;
	private bool growth;
	private bool degrade;

	void Start(){

		growth = false;
		degrade = false;

	}

	void Update () {	

		if (growth && Player1Tree.gameObject.transform.localScale.x <= 0.25f) {

			Player1Tree.gameObject.transform.localScale += new Vector3 (0.0005f, 0.0005f, 0);
		}

		else if (growth && Player1House.gameObject.transform.localScale.x <= 0.25f) {

			Player1House.gameObject.transform.localScale += new Vector3 (0.0005f, 0.0005f, 0);
		}


			if (!growth) {

				StartCoroutine (Stagnation ());

			}

		if (degrade && Player1Tree.gameObject.transform.localScale.x > 0.05f) {

			Player1Tree.gameObject.transform.localScale -= new Vector3 (0.0001f, 0.0001f, 0);
		} 

		else if (degrade && Player1House.gameObject.transform.localScale.x > 0.05f) {

			Player1House.gameObject.transform.localScale -= new Vector3 (0.0001f, 0.0001f, 0);
		}
	}

	void OnTriggerEnter (Collider other) {
		{
		if(other.gameObject == Player1Tree)
		
		if(other.gameObject == Player1House)
						
			degrade = false;
			growth = true;

		}

	}

	void OnTriggerExit (Collider other) {
		{
		if(other.gameObject == Player1Tree)

		if(other.gameObject == Player1House)

			growth = false;

		}

	}

	IEnumerator Stagnation(){

		yield return new WaitForSeconds (10);
		degrade = true;

	}

}