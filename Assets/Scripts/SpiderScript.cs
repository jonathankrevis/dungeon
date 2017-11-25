using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpiderScript : LifeScript {

	public Transform Destination;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		GetComponent<NavMeshAgent>().destination = Destination.position;

	}

	public override void Damage(int d) {
		base.Damage(d);

		GetComponent<Animator>().SetInteger("Pv", Pv);

		if (Pv <= 0) {
			GetComponent<BoxCollider>().enabled = false;
			GetComponent<NavMeshAgent>().enabled = false;
			Destroy(this);
		}

	}
}
