using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour {
	public Vector3 startposition;

	// Use this for initialization
	void Start () {
		startposition = transform.position;
	}	


	void OnCollisionEnter (Collision c){
		if (c.gameObject.tag == "Death") { 
			transform.position = startposition;
			transform.GetComponent<PlayerInfo> ().score = 0;
			}
		}
	}
