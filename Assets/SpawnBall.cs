using UnityEngine;
using System.Collections;

public class SpawnBall : MonoBehaviour {

	public GameObject ball;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Spawn() {
		Instantiate(ball);
	}
}
