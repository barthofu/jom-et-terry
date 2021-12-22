using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction_GarageDoor : RelaisInteraction {

    public string key = "e";

    public float detectionRadius = 5.0f;

    public float defaultHoldTime = 5.0f;
    public float holdTime;

    private float startTime = 0f;
    private bool held = false;

    public GameObject garageDoorButton;
    public GameObject garageDoor;
    
    public delegate void OpenDoor();
    public static event OpenDoor OnDoorButtonPressed;

    void Update() {
        
        if (Input.GetKeyDown(key) && CanPressButton()) {
            holdTime = (HowManyRelaisDown() + 1) * defaultHoldTime ;
            startTime = Time.time;
        }

        if (Input.GetKey(key) && CanPressButton() && !held)
            if (startTime + holdTime <= Time.time) 
                if (OnDoorButtonPressed != null) {
                    held = true;
                    OnDoorButtonPressed();
                }

        if (Input.GetKeyUp(key))
            held = false;
    }

    public bool CanPressButton() {
        return Vector3.Distance(transform.position, garageDoorButton.transform.position) < detectionRadius;
    }
    
    private int HowManyRelaisDown() {

        int totalDown = 0;

        foreach (GameObject relais in allRelais)
            if (relais.GetComponent<Relais>().IsDown()) 
                totalDown++;

        return totalDown;
    }
}
