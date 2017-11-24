using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderScript : LifeScript {

	public override void Damage(int d) {
		base.Damage(d);

		GetComponent<Animator>().SetInteger("Pv", Pv);

		if (Pv <= 0) {
			GetComponent<BoxCollider>().enabled = false;
		}

	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
