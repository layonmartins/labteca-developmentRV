using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusMenu : MonoBehaviour {

    private GameObject gameController;
    private HUDController hudController;
    public GameObject button;
    private CanvasGroup canvasgroup;

    // Use this for initialization
    void Start () {
        gameController = GameObject.Find("GameController");
        hudController = gameController.GetComponent<HUDController>();
        canvasgroup = button.GetComponent<CanvasGroup>();
    }

    // Update is called once per frame
    void Update() {
        if (hudController.mapUp)
            canvasgroup.alpha = 1f;
        else
            canvasgroup.alpha = 0.2f;

        if (hudController.tabletUp)
            canvasgroup.alpha = 1f;
        else
            canvasgroup.alpha = 0.2f;

        if (hudController.inventoryUp)
            canvasgroup.alpha = 1f;
        else
            canvasgroup.alpha = 0.2f;



    }
}
