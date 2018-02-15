using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassMovement : MonoBehaviour {
	public Vector3 movement;
	public float speed;
	public float hor;
	public float ver;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		transform.Translate(movement * speed);
		ver = Input.GetAxis("Horizontal");
		hor = Input.GetAxis("Vertical");
		movement.x = hor;
		movement.z = -ver;

	}
}