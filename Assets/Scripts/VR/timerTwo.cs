using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerTwo : MonoBehaviour
{
    Image fillImg;
    float timeAmt = 2;
    float time;
    public bool start = false;
    public bool restart = false;

    // Use this for initialization
    void Start()
    {
        fillImg = this.GetComponent<Image>();
        time = timeAmt;
    }

    void reStart()
    {
        time = timeAmt;
        fillImg.fillAmount = 0;
        start = false;
        restart = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (start)
        {
            fillImg.fillAmount = 1;
            if (time > 0)
            {
                time -= Time.deltaTime;
                fillImg.fillAmount = time / timeAmt;
            }
            else
            {
                fillImg.fillAmount = 0;
            }
        }
        if (restart)
            reStart();
    }

    public void HandleTimedInputIn()
    {
        start = true;
        Debug.Log("start=" + start);
    }

    public void HandleTimedInputOut()
    {
        restart = true;
        Debug.Log("restart=" + restart);
    }   
}
