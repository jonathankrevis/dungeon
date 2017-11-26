using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionHealth : MonoBehaviour {

	public int Healvalue;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.GetComponent<DamageScript>())
		{
			c.gameObject.GetComponent<DamageScript>().Heal(Healvalue);
		}

		Destroy(gameObject);
	}
}
