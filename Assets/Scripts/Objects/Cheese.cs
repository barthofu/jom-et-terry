using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cheese : MonoBehaviour
{
    public int ogCheeseResistance = 10000;
    public int cheeseResistance;

    void Start()
    {
        cheeseResistance = ogCheeseResistance;
    }

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
            cheeseResistance--;

            // if (cheeseResistance <= 0)
            //     Debug.Log("the mice have won");
            // else {

            // }


        }
    }


}
