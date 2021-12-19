using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageDoor : MonoBehaviour
{

    public Animator doorAnimation;

    private bool doorOpened = false;
    private bool sabotaged = false;

    void OnEnable () { 
        PlayerActions.OnDoorButtonPressed += ChangeState; 
        MouseActions.OnSabotage += Sabotage; 
    }

    void OnDisable () { 
        PlayerActions.OnDoorButtonPressed -= ChangeState; 
        MouseActions.OnSabotage -= Sabotage;
    }

    void ChangeState () {

        Debug.Log("test");
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
