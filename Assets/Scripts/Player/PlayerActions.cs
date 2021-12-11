using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour {

    public float rayLength = 10f; 
    public int maxNumberOfMouseTraps = 3;
    public int radiusGarageDoorButton = 5;
    public GameObject mouseTrapPrefab;
    public GameObject garageDoorButton;
    public GameObject garageDoor;

    public delegate void OpenDoor();
    public static event OpenDoor OnDoorButtonPressed;

    void Update () {
        // create a mouse trap
        if (Input.GetKeyDown("x") && GetAmountOfMouseTraps() < maxNumberOfMouseTraps) CreateMouseTrap();
        // delete a mouse trap
        else if (Input.GetKeyDown("y")) DeleteMouseTrap();
        // open the garage door
        else if (Input.GetKeyDown("e") && CanPressButton()) {
            if (OnDoorButtonPressed != null)
                OnDoorButtonPressed();
        }
    }

    // ==============================================
    //                Garage door
    // ==============================================

    public bool CanPressButton () {
        
        bool isEnoughNear = (Vector3.Distance(transform.position, garageDoorButton.transform.position) < radiusGarageDoorButton);
        bool isSabotaged = garageDoor.GetComponent<GarageDoor>().isSabotaged();

        return isEnoughNear && !isSabotaged;
    }

    // ==============================================
    //                Mouse traps
    // ==============================================

    public void CreateMouseTrap () {

        GameObject m = Instantiate(
            mouseTrapPrefab,
            transform.position + transform.forward + Vector3.up,
            transform.rotation
        ) as GameObject;
    }


    public void DeleteMouseTrap () {

        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, rayLength)) {
            if (hit.collider.name == "MouseTrap(Clone)") {
                Destroy(hit.collider.gameObject);            
            }
        }
    }

    public GameObject[] GetMouseTraps () {

        return GameObject.FindGameObjectsWithTag("MouseTrap");
    }


    public int GetAmountOfMouseTraps () {

        GameObject[] mouseTraps = GetMouseTraps();
        if (mouseTraps.Length > 0) {
            Debug.Log(mouseTraps.Length);
        }
        return mouseTraps.Length;
    }

}
