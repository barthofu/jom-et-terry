using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HunterAction_RestoreRelais : RelaisInteraction
{
    Controls controls;
    public float actionRange = 5.0f;
    public string key = "e";
    private GameObject relais;
    public GameObject interactText;
    int i;
    void Awake()
    {
        controls = new Controls();
    }
    void Update() {
        if(relais) relais.GetComponent<Relais>().relaisSlider.SetActive(false);
        
        relais = CanInteractWithRelais(actionRange);
        if (relais)
        {
            interactText.SetActive(true);
            i = 0;
            relais.GetComponent<Relais>().relaisSlider.SetActive(true);
            controls.Player.Action.performed += ctx => relais.GetComponent<Relais>().Restore();
        }
        else if (i==0)
        {

            
            interactText.SetActive(false);
            i++;
        }
    }

}
