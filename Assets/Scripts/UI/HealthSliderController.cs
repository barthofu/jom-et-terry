using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSliderController : MonoBehaviour
{

    public Slider slider;
    public GameObject Mouse;
    Mouse mouse;

    public void Start()
    {
        mouse = Mouse.GetComponent<Mouse>();
        slider.maxValue = mouse.hp;
    }

    public void Update()
    {

        slider.value = mouse.hp;
    }
}