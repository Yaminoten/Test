using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<StatesController>().enemyStats.HP = 10;

    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(1))
        {
            gameObject.GetComponent<StatesController>().enemyStats.HP --;
        }
	}
}
