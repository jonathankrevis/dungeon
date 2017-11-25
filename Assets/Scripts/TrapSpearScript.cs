using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSpearScript : MonoBehaviour {

	public Transform SpearStartPosition;
	public GameObject PrefabSpear;
	public float SpearSpeed;
	public float SpeedOccurence;
	float timer = 0;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		Debug.Log(timer);

		if (timer > SpeedOccurence)
		{
			GameObject Spear = Instantiate<GameObject>(PrefabSpear);
			Spear.transform.position = SpearStartPosition.position;
			Spear.GetComponent<Rigidbody>().AddForce(SpearStartPosition.forward * SpearSpeed);
			timer = 0;
		}
	}
}
