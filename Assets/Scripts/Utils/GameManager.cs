using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{

    public bool isGameFinished = false;
    public float timer = 5 * 60;

    public float gravity;

    public Camera mouseCamera;
    public Camera hunterCamera;

    public bool hunterIsPlaying = true;

    void Update () {

        if (timer > 0)
            timer -= Time.deltaTime;

        if (Input.GetKeyDown("w"))
            SwitchPlayer();
    }

    // PLAYER SWITCH

    private void SwitchPlayer() {

        hunterIsPlaying = !hunterIsPlaying;
        hunterCamera.enabled = !hunterCamera.enabled;
        mouseCamera.enabled = !mouseCamera.enabled;
    }

    // TIMER

    public bool IsTimerFinished() => timer <= 0;

    public double FormatedTimer() => Math.Ceiling(timer);

    // GAME

}
