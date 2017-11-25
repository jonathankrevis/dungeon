using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDungeonScript : DamageScript {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public override void Damage(int d) {
		base.Damage(d);

		if (Pv <= 0) {
			// Caracter dies
		}

	}
}
