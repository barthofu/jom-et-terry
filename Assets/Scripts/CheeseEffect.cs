using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheeseEffect : MonoBehaviour
{
    int cheeseResistance = 10000;
    public Slider slider;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Mouse")
        {

        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Mouse")
        {

            Debug.Log(cheeseResistance);
            slider.value = cheeseResistance / 10000;
            cheeseResistance--;
            if (cheeseResistance <= 0)
                Debug.Log("the mice have won");
            else { 
                
            }


        }
    }


}
