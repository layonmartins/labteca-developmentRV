using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetColliderLocomotionButton : MonoBehaviour {

    public GameObject player;
    private HeadLookWalk headlookwallk;

	// Use this for initialization
	void Start () {
        headlookwallk = player.GetComponent<HeadLookWalk>();
    }
	
	// Update is called once per frame
	void Update () {

    }

    void OnCollisionEnter(Collision col)
    {
        headlookwallk.isWalking = false;
    }
}
