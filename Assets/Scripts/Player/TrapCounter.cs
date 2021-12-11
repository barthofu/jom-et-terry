using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrapCounter : MonoBehaviour
{
    int nbMouseTrap;
    public Text trapText;
    PlayerActions playerActions;
    GameObject player;

    void Start () {

        player = GameObject.Find("Player");
        playerActions = player.GetComponent<PlayerActions>();
        nbMouseTrap = playerActions.maxNumberOfMouseTraps - playerActions.GetAmountOfMouseTraps();
    }

    // Update is called once per frame
    void Update () {
        nbMouseTrap = playerActions.maxNumberOfMouseTraps - playerActions.GetAmountOfMouseTraps();
        trapText.text = "pi�ges : " + nbMouseTrap;
    }
}
