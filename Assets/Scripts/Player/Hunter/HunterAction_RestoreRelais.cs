using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunterAction_RestoreRelais : RelaisInteraction
{

    public float actionRange = 5.0f;
    public string key = "e";
    private GameObject relais;
    public GameObject interactText;
    int i;
    void Update() {
        if(relais) relais.GetComponent<Relais>().relaisSlider.SetActive(false);
        
        relais = CanInteractWithRelais(actionRange);
        if (relais)
        {
            interactText.SetActive(true);
            i = 0;
            relais.GetComponent<Relais>().relaisSlider.SetActive(true);
            if (Input.GetKey(key)) relais.GetComponent<Relais>().Restore();
        }
        else if (i==0)
        {

            
            interactText.SetActive(false);
            i++;
        }
    }

}
