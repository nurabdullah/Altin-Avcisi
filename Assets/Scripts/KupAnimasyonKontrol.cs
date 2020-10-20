using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KupAnimasyonKontrol : MonoBehaviour {
	float sayac =2f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		sayac -= Time.deltaTime;
		if (sayac < 0) {
			GetComponent<Animator> ().Play (0);
			sayac = Random.Range (4, 6);
		}
	}
}
