using UnityEngine;
using System.Collections;

public class TerrainSetParent: MonoBehaviour {


	// Use this for initialization
	void Start () {

		transform.SetParent (GameObject.FindGameObjectWithTag ("TerrainHolder").transform);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
