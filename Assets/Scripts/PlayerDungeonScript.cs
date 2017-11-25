using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDungeonScript : DamageScript {

	public AudioClip DamageSound; 
	public AudioClip DeathSound; 
	private AudioSource AudioSource;

	// Use this for initialization
	void Start () {
		AudioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public override void Damage(int d) {
//		base.Damage(d);
//		Debug.Log(Pv);
//
//		if (Pv <= 0) {
//			AudioSource.clip = DeathSound;
//			AudioSource.Play();
//		} else {
//			AudioSource.clip = DamageSound;
//			AudioSource.Play();
//		}

	}
}
