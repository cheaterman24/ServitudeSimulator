using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NPCController : MonoBehaviour {
	Text name, body;
	// Use this for initialization
	void Start () {
		name = GameObject.FindGameObjectWithTag ("TextName");
		body = GameObject.FindGameObjectWithTag ("TextBody");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			//initiate Dialog
		}
	}
}
