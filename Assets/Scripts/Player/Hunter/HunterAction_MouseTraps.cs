using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunterAction_MouseTraps : MonoBehaviour {

    public float rayLength = 10f; 
    public int maxNumberOfMouseTraps = 3;

    public GameObject mouseTrapPrefab;

    void Update() {
        
        if (Input.GetKeyDown("x")) {
            GameObject mouseTrap = TestMouseTrap();
            if (mouseTrap) 
                DeleteMouseTrap(mouseTrap);
            else if (GetAmountOfMouseTraps() < maxNumberOfMouseTraps) 
                CreateMouseTrap();
        };
    }

    public GameObject TestMouseTrap () {

        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, rayLength)) {
            if (hit.collider.name == "MouseTrap(Clone)") {
                return hit.collider.gameObject;           
            }
        }
        return null;
    }

    public void CreateMouseTrap () {

        GameObject m = Instantiate(
            mouseTrapPrefab,
            transform.position + transform.forward + Vector3.up,
            transform.rotation
        ) as GameObject;
    }


    public void DeleteMouseTrap (GameObject mouseTrap) {

        Destroy(mouseTrap);
    }

    public GameObject[] GetMouseTraps () {

        return GameObject.FindGameObjectsWithTag("MouseTrap");
    }


    public int GetAmountOfMouseTraps () {

        GameObject[] mouseTraps = GetMouseTraps();
        return mouseTraps.Length;
    }
}
