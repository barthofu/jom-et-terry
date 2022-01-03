using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderControl : MonoBehaviour
{

    public Slider slider;
    public GameObject cheeseSphere;
    Cheese cheese;

    public void Start()
    {
        cheese = cheeseSphere.GetComponent<Cheese>();
        slider.maxValue = cheese.ogCheeseResistance;
    }

    public void Update()
    {

        slider.value = 10000 - cheese.cheeseResistance;
    }
}
