using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	GameObject player;
	Vector3 cameraPos;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		cameraPos = new Vector3 (player.transform.position.x, 5f, player.transform.position.z - 10);
		transform.position = cameraPos;
	}
}
