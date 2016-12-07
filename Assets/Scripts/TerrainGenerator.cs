using UnityEngine;
using System.Collections;

public class TerrainGenerator : MonoBehaviour {

	Object terrain128;
	Object terrain64;
	public bool x128;
	//BoxCollider2D bc;
	public float terrainLength;

	// Use this for initialization
	void Start () {
		terrain128 = Resources.Load ("Prefabs/Terrain 128x128");
		terrain64 = Resources.Load ("Prefabs/Terrain 64x64");
		if (x128) {
			GenFlat128 ();
		} else
			GenFlat64 ();
	}

	public void GenFlat128(){ //do not run in update
		
		//determine starting X-pos
		float startPos = 0;

		startPos = -(terrainLength * (128f/100f))/2f + (64f/100f);
		float index = 0;
		while (index < terrainLength) {
			Instantiate (terrain128, new Vector3 (startPos + (index * 128f/100f), 0, 0), Quaternion.identity);
			index++;
		}

		BoxCollider2D bc = gameObject.AddComponent <BoxCollider2D>() as BoxCollider2D;
		bc.enabled = true;
		bc.offset = Vector2.zero;
		bc.size = new Vector2 (terrainLength * (128f / 100f), (128f / 100f));
	}

	public void GenFlat64(){

		float startPos = 0;

		startPos = -(terrainLength * (64f/100f))/2f + (32f/100f);
		float index = 0;
		while (index < terrainLength) {
			Instantiate (terrain64, new Vector3 (startPos + (index * 64f/100f), 0, 0), Quaternion.identity);
			index++;
		}

		BoxCollider2D bc = gameObject.AddComponent <BoxCollider2D>() as BoxCollider2D;
		bc.enabled = true;
		bc.offset = Vector2.zero;
		bc.size = new Vector2 (terrainLength * (64f / 100f), (64f / 100f));
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
