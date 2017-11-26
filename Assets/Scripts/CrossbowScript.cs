using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossbowScript : MonoBehaviour {

	public Transform ArrowStartPosition;
	public GameObject PrefabArrow;
	public float ArrowSpeed;
	public AudioClip ShootSound; 
	private AudioSource AudioSource;

	// Use this for initialization
	void Start () {
		AudioSource = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			GameObject Arrow = Instantiate<GameObject>(PrefabArrow);
			Arrow.transform.position = ArrowStartPosition.position;
			Arrow.transform.rotation = ArrowStartPosition.rotation;

			AudioSource.clip = ShootSound;
			AudioSource.Play();

			Arrow.GetComponent<Rigidbody>().AddForce(ArrowStartPosition.forward * ArrowSpeed);
		}
	}
}
