using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTransitionScript : MonoBehaviour {

	public float timer = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
//		GetComponent<Animator>().SetFloat("Time", timer);

		if (timer > 10) {
			timer = 0;
			GetComponent<Animator>().SetTrigger("HasToDoSecondAnim");
		}
	}
}
