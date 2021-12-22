using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction_GarageDoor : MonoBehaviour {

    public int detectionRadius = 5;

    public GameObject garageDoorButton;
    public GameObject garageDoor;
    
    public delegate void OpenDoor();
    public static event OpenDoor OnDoorButtonPressed;

    void Update() {
        
        if (Input.GetKeyDown("e") && CanPressButton()) {
            if (OnDoorButtonPressed != null)
                OnDoorButtonPressed();
        }
    }

    public bool CanPressButton () {
        
        bool isEnoughNear = (Vector3.Distance(transform.position, garageDoorButton.transform.position) < detectionRadius);
        bool isSabotaged = garageDoor.GetComponent<GarageDoor>().isSabotaged();

        return isEnoughNear && !isSabotaged;
    }
}
