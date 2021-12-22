using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelaisInteraction : MonoBehaviour
{

    protected GameObject[] allRelais;

    void Start() {

        allRelais = GameObject.FindGameObjectsWithTag("Relais");
    }

    protected GameObject CanInteractWithRelais(float interactionRange) {

        foreach (GameObject relais in allRelais) {
            if (Vector3.Distance(transform.position, relais.transform.position) < interactionRange) return relais;
        }

        return null;
    }
}
