using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearScript : MonoBehaviour {

	public int SpearDamage;

	// Use this for initialization
	void Start () {
		Destroy(gameObject, 4);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionEnter(Collision c)
	{
		if (c.gameObject.GetComponent<DamageScript>())
		{
			c.gameObject.GetComponent<DamageScript>().Damage(SpearDamage);
		}

		Destroy(gameObject);
	}
}
