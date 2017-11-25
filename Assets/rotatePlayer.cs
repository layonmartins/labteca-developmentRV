using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatePlayer : MonoBehaviour {
    public float newRotationY;
    public GameObject player;

	// Use this for initialization
	void Start () {
        Quaternion newRotation = player.transform.rotation;
        newRotation.y = newRotationY;
        player.transform.rotation = newRotation;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
