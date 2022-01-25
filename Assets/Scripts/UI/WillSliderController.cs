using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WillSliderController : MonoBehaviour
{

    public Slider slider;
    public GameObject Mouse;
    Mouse mouse;

    public void Start()
    {
        mouse = Mouse.GetComponent<Mouse>();
        slider.maxValue = mouse.ogWill;
    }

    public void Update()
    {

        slider.value = slider.maxValue - mouse.will;
    }
}