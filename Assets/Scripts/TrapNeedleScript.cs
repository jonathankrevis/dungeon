using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapNeedleScript : MonoBehaviour {
	float timer = 0;
	public int NeedleDamage;
	public float SpeedOccurence;
		
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
	}

	private void OnCollisionEnter(Collision c)
	{
		if (c.gameObject.GetComponent<DamageScript>() && timer > SpeedOccurence)
		{
			timer = 0;
			c.gameObject.GetComponent<DamageScript>().Damage(NeedleDamage);
		}
	}
}
