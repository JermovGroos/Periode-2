using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {
	public Transform gunBarrel;
	public GameObject rocket;
	public GameObject rocketClone;
	public float rocketspeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1"))
		{
			rocketClone = Instantiate (rocket, gunBarrel.transform.position, gunBarrel.rotation);
			rocketClone.GetComponent<Rigidbody> ().velocity = gunBarrel.transform.forward * rocketspeed;
		}
	}
}