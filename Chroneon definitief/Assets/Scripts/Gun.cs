using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
	public float damage = 20f;
	public float range = 100f;
	public float fireRate =15f;

	public AudioSource source;
	public AudioClip clip;
	public Camera shootCam;
	public ParticleSystem Flash;
	public GameObject onHitEffect;
	private float fireCoolDown =0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Fire1")&& Time.time >=fireCoolDown) {
			Shoot ();
			fireCoolDown = Time.time + 1f / fireRate;
			source.clip =clip;
			source.Play();
			}
		}
		void Shoot () {
		Flash.Play();
		RaycastHit hit;
		if (Physics.Raycast(shootCam.transform.position, shootCam.transform.forward, out hit, range)) {
			Debug.Log(hit.transform.name);
			Target target = hit.transform.GetComponent<Target> ();
		if (target != null) {
			target.DamageHit (damage);
			}
			GameObject impactGameObject = Instantiate (onHitEffect, hit.point, Quaternion.LookRotation (hit.normal));
			Destroy (impactGameObject, 2f);
		}
	}
}