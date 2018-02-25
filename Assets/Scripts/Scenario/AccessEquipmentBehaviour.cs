﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//! Allows any Equipment to be interactable.



public class AccessEquipmentBehaviour : InteractObjectBase {

	public GameStateBase targetEquipment;      /*!< GameStateBase for equipment. */
	public Canvas descriptionCanvas;
	public float delay = 0.5f;                  /*!< Float delay time. */
	public float fadeTime;
	public string equipName;
	public bool trigger;
	private float currentDelay;
	private float canvasAlpha=1f;
	public float timeLeft;
	private bool callInteract,fadedOut,firstTimeTrigger;
    public GameObject player;
    public Vector3 newPosition;
    public float newRotationY;
    public GameObject ActionButton;
    public GameObject phMeterButton;
    public Canvas canvasLigarMedir;
    public Button map;
    public Button exit;
    public Canvas dicaLocomotionCanvas;
    public Image setinha;
    //private MostrarDica mostrarDica;



    void Start(){
		if (fadeTime == 0)
			fadeTime = .5f;
		if (descriptionCanvas != null) {
			setCanvasAlphaForce(0f);
		}
		fadedOut = true;
        setinha.gameObject.SetActive(false);
      //  mostrarDica = GetComponent<MostrarDica>();

    }

	void Update () {
		if(callInteract){
			currentDelay += Time.deltaTime;

			if(currentDelay > delay){
				callInteract = false;
				if(targetEquipment!=null)
					targetEquipment.StartState();
				currentDelay = 0;

			}
		}
        //Debug.Log("Player Rotation Y: " + player.transform.rotation.y);

       

    }

	void FixedUpdate(){
		if (firstTimeTrigger) {
			timeLeft = fadeTime;
			firstTimeTrigger = false;
		}

		if (trigger) {
			if (timeLeft <= 0f) {
				setCanvasAlphaForce (canvasAlpha);
			} else {
				float increment = (canvasAlpha - descriptionCanvas.GetComponentInChildren<Image> ().color.a)*Time.fixedDeltaTime/timeLeft;
				setCanvasAlphaForce (descriptionCanvas.GetComponentInChildren<Image> ().color.a + increment);
				timeLeft -= Time.deltaTime;
			}
		}else{
			if (timeLeft <= 0f) {
				setCanvasAlphaForce (0);
			} else {
				float increment = (0 - descriptionCanvas.GetComponentInChildren<Image> ().color.a)*Time.fixedDeltaTime/timeLeft;
				setCanvasAlphaForce (descriptionCanvas.GetComponentInChildren<Image> ().color.a + increment);
				timeLeft -= Time.deltaTime;
			}
		}
	}

     //! Does the interaction.
    /*! Fades the camera and starts the equipment state. */
	public override void Interact ()
	{
		callInteract = true;
		HudText.SetText("");
		GetComponent<BoxCollider>().enabled = false;
        //arrumar a posição do player
        player.transform.position = newPosition;
        //Quaternion newRotation = player.transform.rotation;
        //newRotation.y = newRotationY;
        //player.transform.rotation = newRotation;

        //Ativar o Timed Input do botão Action
        ActionButton.GetComponent<TimedInputObject>().enabled = true;
        phMeterButton.GetComponent<CanvasGroup>().alpha = 0.8f;
        canvasLigarMedir.GetComponent<CanvasGroup>().alpha = 0.5f;
        map.GetComponent<TimedInputObject>().enabled = false;
        exit.GetComponent<TimedInputObject>().enabled = false;
        exit.GetComponent<CanvasGroup>().alpha = 0f;
        dicaLocomotionCanvas.GetComponent<CanvasGroup>().alpha = 0f;
        dicaLocomotionCanvas.enabled = false;
        setinha.gameObject.SetActive(true);
        //mostrarDica.ChamarMostrarDica();
    }

	/*public void fadeIn(){
		descriptionCanvas.enabled = true;
		isFadingOut = false;
		if (!isFadingIn)
			timeLeft = fadeTime;
		if (descriptionCanvas.GetComponentInChildren<Image> ().color.a != canvasAlpha)
			isFadingIn = true;
		else
			isFadingIn = false;
	}
	public void fadeOut(){
		descriptionCanvas.enabled = false;
		isFadingIn = false;
		if (!isFadingOut)
			timeLeft = fadeTime;
		if (descriptionCanvas.GetComponentInChildren<Image> ().color.a > 0)
			isFadingOut = true;
		else
			isFadingOut = false;
	}*/

	public void setCanvasAlpha(float a){
		canvasAlpha = a;
	}

	public void SetTrigger(bool b){
		if (trigger != b)
			firstTimeTrigger = true;
		trigger = b;
	}

	private void setCanvasAlphaForce(float a){
		Color cor = descriptionCanvas.GetComponentInChildren<Image>().color;
		cor.a=a;
		descriptionCanvas.GetComponentInChildren<Image>().color=cor;
	}
}
