using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassMovement : MonoBehaviour {
	public Vector3 v;
	public float hor;
	public float ver;
	public int score;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		hor = Input.GetAxis ("Vertical");
		ver = Input.GetAxis ("Horizontal");
		v.x = hor;
		v.z = -ver;
		transform.Translate (v * Time.deltaTime * -30);
	

	       }
      }
