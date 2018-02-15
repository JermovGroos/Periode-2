using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plasmaball : MonoBehaviour {
	public float speed = 10f;
	public int damage =1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0, 0, speed * Time.deltaTime);
	}
	void OnTriggerEnter (Collider other) {
		PlayerInfo player = other.GetComponent<PlayerInfo> ();
		if (player != null) {
			player.hurt (damage);
		}
		Destroy (gameObject);
	}
}
