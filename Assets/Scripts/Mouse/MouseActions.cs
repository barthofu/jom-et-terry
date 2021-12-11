using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseActions : MonoBehaviour
{

    public int radiusGarageDoor = 2;
    public GameObject garageDoor;

    public delegate void Sabotage();
    public static event Sabotage OnSabotage;

    void Update () {

        if (Input.GetKeyDown("e") && CanSabotage()) {
            if (OnSabotage != null)
                OnSabotage();
        }
    }

    public bool CanSabotage() {

        bool isEnoughNear = Vector3.Distance(transform.position, garageDoor.transform.position) < radiusGarageDoor;
        bool isAlreadySabotaged = garageDoor.GetComponent<GarageDoor>().isSabotaged();
        
        return isEnoughNear && !isAlreadySabotaged;
    }
}
