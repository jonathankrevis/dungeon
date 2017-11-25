using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour {

	public int Pv;
	public AudioClip DamageSound; 
	public AudioClip DeathSound; 
	private AudioSource AudioSource;

	public virtual void Damage(int d) {
		Pv -= d;
		Debug.Log(Pv);

		if (Pv <= 0) {
			AudioSource.clip = DeathSound;
			AudioSource.Play();
		} else {
			AudioSource.clip = DamageSound;
			AudioSource.Play();
		}
	}

	// Use this for initialization
	void Start () {
		AudioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
