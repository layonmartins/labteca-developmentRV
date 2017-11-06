using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.Events;

public class TimedInputObject : MonoBehaviour, TimedInputHandler {

    public Button button;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void HandleTimedInput()
    {
        button.onClick.Invoke();
    }
}
