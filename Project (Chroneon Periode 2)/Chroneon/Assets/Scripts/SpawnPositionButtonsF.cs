using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPositionButtonsF: MonoBehaviour {
	public GameObject g;
	public Vector3 spawnPos;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter (Collision c) {
		if (c.gameObject.name == "ButtonCube") {
			spawnPos.x = (-25.2f);
			spawnPos.y = (22.17f);
			spawnPos.z = (-34.6f);
			Instantiate (g, spawnPos, transform.rotation);
			Destroy (gameObject);
		}
	}
}
