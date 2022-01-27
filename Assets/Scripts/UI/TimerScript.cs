using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    GameManager gamemanager;
    public TextMeshProUGUI timer;
    int i;
    // Start is called before the first frame update
    void Start()
    {
        gamemanager = GameObject.Find("_GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        i = (int) gamemanager.timer;
         timer.text= i.ToString();
    }
}
