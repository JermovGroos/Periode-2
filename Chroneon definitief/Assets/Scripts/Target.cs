using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {
	public float health = 500f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void DamageHit (float number) {
		health -= number;
		if (health <= 0f) {
			Death ();
		}
	}
	void Death () {
		Destroy (gameObject);
	}
}