using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using System;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{

    public bool isGameFinished = false;
    public float timer;

    public float gravity;
    public PlayableDirector truckPicksCheese;

    public Camera hunterCamera;
    public Camera mouseCamera;
    public GameObject ui;

    public bool hunterIsPlaying = true;

    Controls controls;

    void Awake() {

    
        controls = new Controls();
        
        hunterCamera.enabled = true;
        mouseCamera.enabled = false;
        
    }

    void Update() {

        if (timer > 0)
            timer -= Time.deltaTime;
        
    }

    

    // TIMER

    public bool IsTimerFinished() => timer <= 0;

    public double FormatedTimer() => Math.Ceiling(timer);

    // GAME

    public void FinishGame(string whoWon) {

        isGameFinished = true;
        hunterCamera.enabled = false;
        mouseCamera.enabled = false;
        ui.SetActive(false);
        if (whoWon == "hunter")
            HunterWon();
        else 
            MouseWon();
    }

    private void HunterWon() {

        truckPicksCheese.Play();
    }

    private void MouseWon() {
        //
    }

}
