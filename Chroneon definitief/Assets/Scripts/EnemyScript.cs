using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
	public Transform player;
	public int moveSpeed =4;
	public int maxDist = 12;
	public int minDist = 3;
	public bool start;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (start) {
			moveSpeed = 3;
			transform.LookAt (player);
			transform.position += transform.forward * moveSpeed * Time.deltaTime;
			if (Vector3.Distance (transform.position, player.position) <= minDist) {
				moveSpeed = 0;
			}
		}
	}
	private void OnTriggerEnter(Collider other) {
		if(other.tag == "Player") {
			start = true;
		}
	}
	private void OnTriggerExit (Collider other) {
		if (other.tag == "Player") {
			start = false;
		}
	}
}