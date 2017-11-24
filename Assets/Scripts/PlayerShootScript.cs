using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootScript : MonoBehaviour {

	public Transform BulletStartPosition;
	public GameObject PrefabBullet;
	public float BulletSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			GameObject Bullet = Instantiate<GameObject>(PrefabBullet);
			Bullet.transform.position = BulletStartPosition.position;
			Bullet.GetComponent<Rigidbody>().AddForce(BulletStartPosition.forward * BulletSpeed);
		}
	}
}
