using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonView : MonoBehaviour {
	
	public float sensitivity = 2f;

	public GameObject eyes;
	public float RotX;
	public float RotY;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		RotX = Input.GetAxis ("Mouse X") * sensitivity;
		RotY = Input.GetAxis ("Mouse Y") * sensitivity;

		transform.Rotate (0, RotX, 0);
		eyes.transform.Rotate (0, 0, -RotY);

	}
}
