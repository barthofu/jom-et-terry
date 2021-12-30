using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrapCounter : MonoBehaviour
{
    int nbMouseTrap;
    public Text trapText;
    HunterAction_MouseTraps hunterMouseTraps;
    GameObject hunter;

    void Start () {

        hunter = GameObject.Find("Hunter");
        hunterMouseTraps = hunter.GetComponent<HunterAction_MouseTraps>();
        nbMouseTrap = hunterMouseTraps.maxNumberOfMouseTraps - hunterMouseTraps.GetAmountOfMouseTraps();
    }

    // Update is called once per frame
    void Update () {
        nbMouseTrap = hunterMouseTraps.maxNumberOfMouseTraps - hunterMouseTraps.GetAmountOfMouseTraps();
        trapText.text = "pièges : " + nbMouseTrap;
    }
}
