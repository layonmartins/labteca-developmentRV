using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadLookWalk : MonoBehaviour {

    public float velocity = 0.4f;
    public bool isWalking = false;
    private CharacterController controller;
    
    
    

	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
	}
	

	// Update is called once per frame
	void Update () {

        if (isWalking)
        {

            controller.SimpleMove(Camera.main.transform.forward * velocity);

        }
        else
        {
            velocity = 0.4f;
            StopCoroutine(Acelera());
        }
    }

    public void StartAcelera()
    {
        StartCoroutine(Acelera());
    }

    IEnumerator Acelera()
    {
        while (velocity < 1.2f)
        {
            yield return new WaitForSecondsRealtime(0.1f);
            velocity += 0.04f;
        }

    }
}
