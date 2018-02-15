using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour {
	public int score;
	public int Health;

	// Use this for initialization
	void Start () {
		Health = 10;
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void hurt(int damage) {
		Health -= damage;
		Debug.Log("Health" + Health);
	}
}
