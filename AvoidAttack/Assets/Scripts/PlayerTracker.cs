using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTracker : MonoBehaviour {

	#region Singleton

	public static PlayerTracker instance;

	// Use this for initialization
	void Awake () {

		instance = this;

	}
		
	#endregion

	public GameObject Player; 
	}

