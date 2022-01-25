using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseTrapEffect : MonoBehaviour
{ 

    GameObject mouse, mouseFake;
    Mouse Mouse;
    int v;
    public Slider willSlider;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Mouse")
        {
            mouse = other.gameObject;
            Mouse = mouse.GetComponent<Mouse>();
            v = Mouse.ogWill;
            willSlider.enabled = true;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Mouse")
        {
            mouse = other.gameObject;
            Mouse = mouse.GetComponent<Mouse>();
            if (Mouse.will <= 0)
            {
                mouse.transform.position = transform.position;
                Mouse.deadCount++;
                mouse.GetComponent<CharacterController>().enabled=false;
            } else{
                Mouse.will--;
                Debug.Log(Mouse.will);
                mouse.GetComponent<CharacterController>().Move((transform.position - mouse.transform.position) * Time.deltaTime);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Mouse")
        {
            willSlider.enabled = false;
        }
    }

}

