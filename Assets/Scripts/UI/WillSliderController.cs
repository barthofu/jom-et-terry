using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WillSliderController : MonoBehaviour
{

    public Slider slider;
    public GameObject Relais;
    Relais relais;

    public void Start()
    {
        relais = Relais.GetComponent<Relais>();
        slider.maxValue = relais.baseHp;
    }

    public void Update()
    {

        slider.value = relais.hp;
    }
}