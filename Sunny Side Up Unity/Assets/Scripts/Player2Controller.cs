using UnityEngine;
using System.Collections;

public class Player2Controller : MonoBehaviour {

	//public float RotationSpeed = 10.0f; maybe needed
	public float turnSpeed = 50f;


	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey(KeyCode.LeftArrow))
			transform.Rotate(Vector3.forward, -turnSpeed * Time.deltaTime);

		if(Input.GetKey(KeyCode.RightArrow))
			transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime);
	}
}
