using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{

    public float rayLength = 10f; 
    public int maxNumberOfMouseTraps = 3;
    public GameObject mouseTrapPrefab;

    void Update()
    {
        if (Input.GetKeyDown("x") && getAmountOfMouseTraps() < maxNumberOfMouseTraps) createMouseTrap();
        else if (Input.GetKeyDown("y")) deleteMouseTrap();
    }


    //MouseTraps
    public void createMouseTrap () {

        GameObject m = Instantiate(
            mouseTrapPrefab,
            transform.position + transform.forward + Vector3.up,
            transform.rotation
        ) as GameObject;
    }


    public void deleteMouseTrap () {

        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, rayLength)) {
            if (hit.collider.name == "MouseTrap(Clone)") {
                Destroy(hit.collider.gameObject);            
            }
        }
    }


    public GameObject[] getMouseTraps () {

        return GameObject.FindGameObjectsWithTag("MouseTrap");
    }


    public int getAmountOfMouseTraps () {

        GameObject[] mouseTraps = getMouseTraps();
        return mouseTraps.Length;
    }

}
