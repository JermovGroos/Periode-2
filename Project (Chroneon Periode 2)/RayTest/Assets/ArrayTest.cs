using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTest : MonoBehaviour {
	public int [] i;
	public List <int> il = new List<int> ();
	public bool []j;

	// Use this for initialization
	void Start () {
		i [2] = 20;
		if( i[2]==20){
			print ("hoi");
		}
		il.Add (1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
