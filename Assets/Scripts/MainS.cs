using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainS : MonoBehaviour {
	public float Speed;
	public float RSpeed;
	public GameObject cubespeed;
	public GameObject cubeback;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position=new Vector3(gameObject.transform.position.x,123f, gameObject.transform.position.z);
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (Vector3.right * Speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (Vector3.right * -1 * Speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate (Vector3.up * RSpeed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate (Vector3.up *-1* RSpeed * Time.deltaTime);
		}
	}
	void OnTriggerEnter(Collider col){
		if (col.tag == "Speed+") {
			Speed = Speed + 10f;
			RSpeed = RSpeed + 15f;
			cubespeed.SetActive (false);
		}
		if (col.tag == "Back") {
			gameObject.transform.position=new Vector3(30.45f,123f, -534.4f);
			Speed = 10f;
			RSpeed = 150f;
			cubeback.SetActive (false);
			cubespeed.SetActive (true);
		}
	}
}
