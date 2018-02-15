using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
	public Rigidbody r;
	public Vector3 v;
	public bool mayJump;
	public int xJump;

	// Use this for initialization
	void Start () {
		r = GetComponent<Rigidbody> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Jump")) {
			if(mayJump == true){
				r.velocity = v;
				xJump += 1;
			
			}
		}
		if(xJump==2){
				mayJump =false;
				xJump =0;
			}
	}
	void OnCollisionEnter(Collision c) {
		if (c.gameObject.tag == "Ground") {
			mayJump = true;
		}

	}
}