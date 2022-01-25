using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cheese : MonoBehaviour
{
    public int ogCheeseResistance = 10000;
    public int cheeseResistance;
    public GameObject cheeseSlider;

    void Start()
    {
        cheeseResistance = ogCheeseResistance;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Mouse")
        {
            cheeseSlider.SetActive(true);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Mouse")
        {
            Debug.Log(cheeseResistance);
            cheeseResistance--;

            if (cheeseResistance <= 0)
                Debug.Log("the mice have won");
            else {

            }


        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Mouse")
        {
            cheeseSlider.SetActive(false);
        }
    }



}
