using UnityEngine;
using System.Collections;

public class AppleTree : MonoBehaviour {
	//Prefab for insantiating apples
	public GameObject applePreFab;

	//Speed at which the AppleTree moves in meters/seconds
	public float speed=1f;

	//Distance where AppleTree turns around
	public float leftAndRightEdge = 20f;

	//Chance that the AppleTree will change directions
	public float chanceToChangeDirections = 0.1f;

	//Rate at which Apples will be instantiated
	public float secondsBetweenAppleDrops = 1f;

	// Use this for initialization
	void Start () {
		//Dropping apples every second
		InvokeRepeating ("DropApple", 2f, secondsBetweenAppleDrops);
	}
		void DropApple(){
		GameObject apple = Instantiate (applePreFab) as GameObject;
				apple.transform.position = transform.position;
		}
	
	// Update is called once per frame
	void Update () {
		//Basic movement
		Vector3 pos = transform.position;
		pos.x += speed * Time.deltaTime;
		transform.position = pos;

		//Changing Direction
		if (pos.x < -leftAndRightEdge) {
			speed = Mathf.Abs (speed); //Move Right
		} else if (pos.x > leftAndRightEdge) {
			speed = -Mathf.Abs (speed); //Move left
		}
	}
	void FixedUpdate() {
		if (Random.value < chanceToChangeDirections) {
			speed *= -1; //Change Direction
		}
	}
}
