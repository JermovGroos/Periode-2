using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour {
	public int weaponTrue = 0;

	// Use this for initialization
	void Start () {
		SelectWeapon ();
		
	}
	
	// Update is called once per frame
	void Update () {
		int lastSelectedWeapon = weaponTrue;

		if (Input.GetAxis ("Mouse ScrollWheel") > 0f) {
			if (weaponTrue >= transform.childCount - 1)
				weaponTrue = 0;
			else
				weaponTrue++;
		}
		if (Input.GetAxis ("Mouse ScrollWheel") < 0f) {
			if (weaponTrue <= 0)
				weaponTrue = transform.childCount - 1;
			else
				weaponTrue--;
		}
		if (Input.GetKeyDown(KeyCode.Alpha1)) {
			weaponTrue = 0;
		}
		if (Input.GetKeyDown (KeyCode.Alpha2) && transform.childCount >=2) {
			weaponTrue = 1;
		}
		if (lastSelectedWeapon != weaponTrue) {
			SelectWeapon ();
		}
	}
	void SelectWeapon () {
		int i = 0;
		foreach (Transform weapon in transform) {
			if (i == weaponTrue)
				weapon.gameObject.SetActive (true);
			else
				weapon.gameObject.SetActive (false);
				
			i++;

		}
	}
}
