using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceStatesController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<StatesController>().enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
