using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {
	public Vector3 spawnPos;
	public GameObject g;
	public int i;
	public Vector3 RotateVector;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}


	void OnCollisionEnter (Collision c){ 

		if (c.gameObject.name == "Hand")
		{
			c.gameObject.GetComponent<ClassMovement> ().score += 1;

			Instantiate (g, spawnPos, Quaternion.identity); 
			Destroy(gameObject);


		
		}
	}
}
