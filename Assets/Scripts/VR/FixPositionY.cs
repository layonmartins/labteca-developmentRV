using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixPositionY : MonoBehaviour {

    public GameObject cardboardmain;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        //fix position Y and rotation Z
        Vector3 position = transform.position;
        Quaternion rotation = transform.rotation;
        position.y = cardboardmain.transform.position.y - 0.15f;
        rotation.x = 0f;
        //rotation.y = 0f;
        rotation.z = 0f;
        transform.position = position;
        transform.rotation = rotation;
        
    }
}
