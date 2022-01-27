using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAction_SabotageRelais : RelaisInteraction
{

    public float actionRange = 5.0f;
    public int damages = 2;
    public GameObject interactText;
    private int lastTimeInt = -1;
    public string key = "e";
    int i;

    private GameObject relais;
    void Update() {
        relais = CanInteractWithRelais(actionRange);

        if (relais) {
            interactText.SetActive(true);
            i = 0;
            if (Input.GetKey(key))
            {
                if ((int)Time.time > lastTimeInt) relais.GetComponent<Relais>().TakeDamages(damages);
                lastTimeInt = (int)Time.time;
                relais.GetComponent<Relais>().relaisSlider.SetActive(true);
            }
            else if (lastTimeInt != 1)
            {

                lastTimeInt = -1;
                relais.GetComponent<Relais>().relaisSlider.SetActive(false);
            }
            else
            {
                relais.GetComponent<Relais>().relaisSlider.SetActive(false);
            }
        }
        else if (i==0)
        {
            i++;
            interactText.SetActive(false);
        }
    }


}
