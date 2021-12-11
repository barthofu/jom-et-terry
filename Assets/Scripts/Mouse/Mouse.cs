using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{

    public int ogwill = 100;
    public int hp = 100;
    public int will;
    public int deadCount = 0;

    void Start()
    {
        will = ogwill;
    }

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
