using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {
	public Vector3 spawnPos;
	public GameObject g;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}


	void OnCollisionEnter (Collision c){ 

		if (c.gameObject.name == "Player")
		{
			c.gameObject.GetComponent<PlayerInfo> ().score += 1;
			Destroy(gameObject);


		
		}
	}
}
