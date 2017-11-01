using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimedInputCanvasButtons : MonoBehaviour, TimedInputHandler {

    public GameController gameController;
    public string button;
    private HUDController hudController;

	// Use this for initialization
	void Start () {
        hudController = gameController.GetComponent<HUDController>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void HandleTimedInput()
    {
        if (button.Equals("InventoryButton"))
        {
            hudController.CallMapTrigger();
        } else if (button.Equals("JournalButton"))
        {
            hudController.CallInventoryTrigger();
        } else if (button.Equals("MapButton"))
        {
            hudController.CallMapTrigger();
        } else
        {
            //ExitCurrentstate();
        }
        
    }
}
