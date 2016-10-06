using UnityEngine;
using System.Collections;

public class AppleTree : MonoBehaviour {
	//Prefab for insantiating apples
	public GameObject applePreFab;

	//Speed at which the AppleTree moves in meters/seconds
	public float speed=1f;

	//Distance where AppleTree turns around
	public float leftAndRightEdge = 10f;

	//Chance that the AppleTree will change directions
	public float chanceToChangeDirections = 0.1f;

	//Rate at which Apples will be instantiated
	public float secondsBetweenAppleDrops = 1f;

	// Use this for initialization
	void Start () {
		//Droppeing apples every second
	
	}
	
	// Update is called once per frame
	void Update () {
		//Basic movement
		//Changing Direction
	}
}
