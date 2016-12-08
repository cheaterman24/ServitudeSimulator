using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TaskManager : MonoBehaviour {

	public List<Task> objectives;
	public List<GameObject> bag;
	public List<GameObject> cottonBag;
	int maxBagSize = 10;


	public void PickUp(ref GameObject o)
	{
		if (bag.Count == maxBagSize) {
			//display bag is full message
			//do not destroy gameobject
		} else {
			//might fuck up with referencing instead of copy
			bag.Add (o);
			Destroy (o);
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
