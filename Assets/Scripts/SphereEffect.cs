using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereEffect : MonoBehaviour
{ 

    GameObject mouse, mouseFake;
    MouseMovement mouseMovement;
    int v;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Mouse")
        {
            mouse = other.gameObject;
            mouseMovement = mouse.GetComponent<MouseMovement>();
            v = mouseMovement.ogwill;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Mouse")
        {
            mouse = other.gameObject;
            mouseMovement = mouse.GetComponent<MouseMovement>();
            mouseMovement.will--;
            Debug.Log(mouseMovement.will);
            mouse.GetComponent<CharacterController>().Move((transform.position-mouse.transform.position) *Time.deltaTime);
        }
    }

}

