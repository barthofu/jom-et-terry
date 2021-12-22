using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction_RestoreRelais : RelaisInteraction
{

    public float actionRange = 5.0f;

    void Update() {
        
        if (Input.GetKey("e")) {
            GameObject relais = CanInteractWithRelais(actionRange);
            if (relais) relais.GetComponent<Relais>().Restore();
        }
    }

}
