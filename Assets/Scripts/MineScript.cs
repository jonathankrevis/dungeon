using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineScript : MonoBehaviour {

	public List<GameObject> ObjectsInRange;
	private float timer = 0;
	public float MineExplosion;

	// Use this for initialization
	void Start () {
		ObjectsInRange = new List<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;

		if (timer > 5)
		{
			foreach(GameObject g in ObjectsInRange)
			{
				g.GetComponent<Rigidbody>().AddForce(
					Vector3.Normalize(g.transform.position - transform.position) * MineExplosion);
			}
			Destroy(gameObject);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.GetComponent<Rigidbody>())
			ObjectsInRange.Add(other.gameObject);
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.GetComponent<Rigidbody>())
			ObjectsInRange.Remove(other.gameObject);
	}
}
