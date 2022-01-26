using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Relais : MonoBehaviour
{

    public int baseHp = 100;
    public int hp;
    public ParticleSystem smoke;

    void Start() {
        hp = baseHp;
        InvokeRepeating("RegenHp", 0.0f, 1f);
    }

    void Update() {
        
        // if (hp <= 0) {
        //     smoke.play();
        // } else {
        //     smoke.stop();
        // }
    }

    private void RegenHp() {
        if (hp < 100 && hp > 0) hp++;
    }

    public void TakeDamages(int damages) {
        hp -= damages;
        if (hp < 0) hp = 0;
    }

    public void Restore() {
        hp = baseHp;
    }

    public bool IsDown() {
        return hp == 0;
    }
}
