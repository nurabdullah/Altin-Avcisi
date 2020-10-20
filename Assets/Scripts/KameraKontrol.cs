using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKontrol : MonoBehaviour {
	public OyunKontrol oyunK;
	float hassasiyet = 5f;
	float yumasaklik =2f;

	Vector2 gecisPos;
	Vector2 camPos;

	GameObject oyuncu;
	// Use this for initialization
	void Start () {
		oyuncu = transform.parent.gameObject;
		camPos.y = 12f;
	}
	
	// Update is called once per frame
	void Update () {
		if (oyunK.oyunAktif) {
			Vector2 farePos = new Vector2 (Input.GetAxis ("Mouse X"), Input.GetAxis ("Mouse Y"));
			farePos = Vector2.Scale (farePos, new Vector2 (hassasiyet * yumasaklik, hassasiyet * yumasaklik));
			gecisPos.x = Mathf.Lerp (gecisPos.x, farePos.x, 1f / yumasaklik);
			gecisPos.y = Mathf.Lerp (gecisPos.y, farePos.y, 1f / yumasaklik);
			camPos += gecisPos;
			transform.localRotation = Quaternion.AngleAxis (-camPos.y, Vector3.right);
			oyuncu.transform.localRotation = Quaternion.AngleAxis (camPos.x, oyuncu.transform.up);
		}
	}
}
