using UnityEngine;
using System.Collections;

public class Player1Controller : MonoBehaviour {

	//public float RotationSpeed = 10.0f; maybe needed
	public float turnSpeed = 50f;


	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey(KeyCode.A))
			transform.Rotate(Vector3.forward, -turnSpeed * Time.deltaTime);

		if(Input.GetKey(KeyCode.D))
			transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime);
	}
}
