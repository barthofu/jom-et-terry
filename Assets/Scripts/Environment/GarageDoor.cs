using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageDoor : MonoBehaviour
{

    public Animator doorAnimation;

    private bool doorOpened = false;
    private float defaultHoldTime = 5.0f;
    private float holdTime;
    
    private bool sabotaged = false;

    void Start () {

        holdTime = defaultHoldTime;
    }

    void OnEnable () { 
        PlayerAction_GarageDoor.OnDoorButtonPressed += ChangeState; 
        MouseActions.OnSabotage += Sabotage; 
    }

    void OnDisable () { 
        PlayerAction_GarageDoor.OnDoorButtonPressed -= ChangeState; 
        MouseActions.OnSabotage -= Sabotage;
    }

    void ChangeState () {

        if (doorOpened) doorAnimation.Play("GarageDoorClose", 0, 0.0f);
        else doorAnimation.Play("GarageDoorOpen", 0, 0.0f);

        doorOpened = !doorOpened;
    }

    void Sabotage () {
        Debug.Log("SABOTAGE");
        sabotaged = !sabotaged;
    }

    public bool isSabotaged () {
        return sabotaged;
    }

}
