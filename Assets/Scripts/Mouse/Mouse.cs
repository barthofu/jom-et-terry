using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{

    public int will = 100;
    private int hp = 100;
    public int deadCount = 0;

    void Update () {
        if (hp <= 0) Respawn();
    }

    public void TakeDamages (int damages) {
        hp -= damages;
    }

    private void Respawn () {
        deadCount++;
    }
}
