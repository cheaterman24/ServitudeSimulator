using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NPCController : MonoBehaviour {
	Text name, body;
	GameObject textBox;
	// Use this for initialization
	void Start () {
		name = GameObject.FindGameObjectWithTag ("TextName").GetComponent<Text> ();
		body = GameObject.FindGameObjectWithTag ("TextBody").GetComponent<Text>();
		textBox = GameObject.FindGameObjectWithTag ("TextBox");
		textBox.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {

		textBox.transform.position = new Vector3 (transform.position.x, transform.position.y + 3f, transform.position.z);
	
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			//initiate Dialog
			textBox.SetActive(true);
			name.text = "TEST NPC";
			body.text = "Hello, How are you?";
		}
	}

	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "Player") {
			textBox.SetActive (false);
		}
	}
}
