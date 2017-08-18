using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObject : MonoBehaviour {

	public GameObject Prefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float playerX = GameObject.FindGameObjectWithTag("Player").transform.position.x;
		float playerY = GameObject.FindGameObjectWithTag("Player").transform.position.y;
		int progress = (int) playerX + 320;
		if (Time.frameCount % 35 == 0) {
			Instantiate (Prefab, new Vector3 (Random.Range(playerX - 10, playerX + 30), Random.Range(playerY+40,playerY+200)), Quaternion.identity);
		}
	}
}
