using UnityEngine;
using System.Collections;

public class TerrainGenerator : MonoBehaviour {

	Object terrain128;
	Object terrain64;
	public int terrainLength;

	// Use this for initialization
	void Start () {
		terrain128 = Resources.Load ("Prefabs/Terrain 128x128");
		terrain64 = Resources.Load ("Prefabs/Traain 64x64");
		GenFlat128 ();
	
	}

	public void GenFlat128(){ //do not run in update
		
		//determine starting X-pos
		float startPos;

		startPos = -(terrainLength/2 * 128)/100;
		float index = 0;
		while (index < terrainLength) {
			Instantiate (terrain128, new Vector3 (startPos + (index * 128/100), 0, 0), Quaternion.identity);
			index++;
		}

	}

	public void GenFlat64(){
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
