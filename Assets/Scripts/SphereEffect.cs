using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereEffect : MonoBehaviour
{ 

    GameObject mouse, mouseFake;
    Mouse Mouse;
    int v;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Mouse")
        {
            mouse = other.gameObject;
            Mouse = mouse.GetComponent<Mouse>();
            v = Mouse.ogwill;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Mouse")
        {
            mouse = other.gameObject;
            Mouse = mouse.GetComponent<Mouse>();
            Mouse.will--;
            Debug.Log(Mouse.will);
            mouse.GetComponent<CharacterController>().Move((transform.position-mouse.transform.position) *Time.deltaTime);
        }
    }

}

