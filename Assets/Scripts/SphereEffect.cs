using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereEffect : MonoBehaviour
{

    GameObject mouse;
    MouseMovement mouseMovement;

    void OnTriggerEnter (Collider other) {
        giveDamages(other);
    }
    
    void OnTriggerStay (Collider other) {
        giveDamages(other);
    }

    private void giveDamages (Collider other) {
        Mouse mouse = other.gameObject.GetComponent<Mouse>();
        if (mouse) {
            mouse.TakeDamages(1);
        }
    }
    
}
