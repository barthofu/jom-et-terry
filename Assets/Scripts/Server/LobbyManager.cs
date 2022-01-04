using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LobbyManager : MonoBehaviour
{
    public Button StartGameButton;
    // Start is called before the first frame update
    void Start()
    {
        if(NetworkServer.active) {
            StartGameButton.gameObject.SetActive(true);
            StartGameButton.onClick.AddListener(StartGameOnClick);
        } else {
            StartGameButton.gameObject.SetActive(false);
        }
    }

    private void StartGameOnClick() {
        NetworkManager.singleton.ServerChangeScene("Hangar");
    }

}
