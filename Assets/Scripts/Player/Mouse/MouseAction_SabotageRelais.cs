using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAction_SabotageRelais : RelaisInteraction
{

    public float actionRange = 5.0f;
    public int damages = 2;

    private int lastTimeInt = -1;

    void Update() {
        
        if (Input.GetKey("e")) {
            GameObject relais = CanInteractWithRelais(actionRange);
            if (relais) {
                if ((int)Time.time > lastTimeInt) relais.GetComponent<Relais>().TakeDamages(damages);
                lastTimeInt = (int)Time.time;
            }
        } else if (lastTimeInt != 1) lastTimeInt = -1;
    }


}
