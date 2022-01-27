using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Relais : MonoBehaviour
{

    public int baseHp = 100;
    public int hp;
    public ParticleSystem smoke;
    // private Animator animator;

    public GameObject relaisSlider;
    
    void Start() {
        hp = baseHp;
        InvokeRepeating("RegenHp", 0.0f, 1f);
        // animator = GetComponent<Animator>();
    }

    void Update() {

        // if (animator != null && animator.isActiveAndEnabled) {
        
            if (hp <= 0) {
                smoke.Play();
                // animator.SetBool("isDown", true);
            } else {
                smoke.Stop();
                // animator.SetBool("isDown", false);
            }
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
