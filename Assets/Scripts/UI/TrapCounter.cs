using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrapCounter : MonoBehaviour
{
    int nbMouseTrap;
    public Text trapText;
    PlayerAction_MouseTraps playerMouseTraps;
    GameObject player;

    void Start () {

        player = GameObject.Find("Player");
        playerMouseTraps = player.GetComponent<PlayerAction_MouseTraps>();
        nbMouseTrap = playerMouseTraps.maxNumberOfMouseTraps - playerMouseTraps.GetAmountOfMouseTraps();
    }

    // Update is called once per frame
    void Update () {
        nbMouseTrap = playerMouseTraps.maxNumberOfMouseTraps - playerMouseTraps.GetAmountOfMouseTraps();
        trapText.text = "pièges : " + nbMouseTrap;
    }
}
