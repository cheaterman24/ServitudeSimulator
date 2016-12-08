using UnityEngine;
using System.Collections;
using System;

public class Task : IComparable<Task>{

	public string description; // description of what the player must do to complete the task
	public string name; // name of the task
	public string type; // type of task, gathering, speaking, action, etc.
	public bool main; // determines if quest is main, or secondary

	public Task(string n, string d, string t)
	{
		name = n;
		description = d;
		type = t;
	}

	public int CompareTo(Task t)
	{
		if (t == null) {
			return 1;
		}

		if (name == t.name) {
			return 0;
		} else
			return 1;
	}

	public string Description {
		get { return description; }
		private set { description = value; }
	}

	public string Name {
		get { return name; }
		private set { name = value; }
	}

	public string Type {
		get { return type; }
		private set { type = value; }
	}

	public void Progress (){
		switch (type) {

		case "gather":
			{
				//collect some amount of...
			}
			break;
		case "talk":
			{
				//speak to...
			}
			break;
		case "give":
			{
				//give something to...
			}
			break;
		}

	}
}
