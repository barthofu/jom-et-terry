using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunterAction_GarageDoor : RelaisInteraction {

    public string key = "e";

    public float detectionRadius = 5.0f;

    public float defaultHoldTime = 5.0f;
    public float holdTime;

    private float startTime = 0f;
    private bool held = false;

    public GameObject garageDoorButton;
    public GameObject garageDoor;


    public GameObject interactText;

    public delegate void OpenDoor();
    public static event OpenDoor OnDoorButtonPressed;
    int i;
    void Update() {

        if (CanPressButton())
        {
            interactText.SetActive(true);
            i = 0;
        }else if(i==0)
        {
            interactText.SetActive(false);
            i++;
        }
        if (Input.GetKeyDown(key) && CanPressButton()) {
            holdTime = (HowManyRelaisDown() + 1) * defaultHoldTime ;
            startTime = Time.time;
        }

        if (Input.GetKey(key) && CanPressButton() && !held)
            if (startTime + holdTime <= Time.time) 
                if (OnDoorButtonPressed != null) {
                    held = true;
                    //OnDoorButtonPressed();
                    GetComponent<Hunter>().gameManager.FinishGame("hunter");
                }

        if (Input.GetKeyUp(key))
            held = false;
    }

    public bool CanPressButton() {

        bool isNearEnough = Vector3.Distance(transform.position, garageDoorButton.transform.position) < detectionRadius;
        bool isTimerFinished = GetComponent<Hunter>().gameManager.IsTimerFinished();

        return isNearEnough && isTimerFinished;
    }
    
    private int HowManyRelaisDown() {

        int totalDown = 0;

        foreach (GameObject relais in allRelais)
            if (relais.GetComponent<Relais>().IsDown()) 
                totalDown++;

        return totalDown;
    }
}
