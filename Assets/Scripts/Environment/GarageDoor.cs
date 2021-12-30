using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageDoor : MonoBehaviour
{

    public Animator doorAnimation;

    private bool doorOpened = false;

    void OnEnable () { 
        HunterAction_GarageDoor.OnDoorButtonPressed += ChangeState;     
    }

    void OnDisable () { 
        HunterAction_GarageDoor.OnDoorButtonPressed -= ChangeState; 
    }

    void ChangeState () {

        if (doorOpened) doorAnimation.Play("GarageDoorClose", 0, 0.0f);
        else doorAnimation.Play("GarageDoorOpen", 0, 0.0f);

        doorOpened = !doorOpened;

        GameObject.Find("_GameManager").GetComponent<GameManager>().FinishGame("hunter");
    }
}
