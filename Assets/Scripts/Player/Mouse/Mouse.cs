using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : Player, IDamageable, IKillable {

    public int ogWill = 100;
    
    public int will;

    public Transform teleportTarget;
    public GameObject collect;

    public void Start() {
        base.Start();
        
        hp = 100;
        will = ogWill;
    }

    void Update() {

        if (!gameManager.hunterIsPlaying && !gameManager.isGameFinished) {

            Move();
            Fall();

            if (hp <= 0 && collect.GetComponent<collectReviveItem>().getItemCount() > 0) 
                Kill();

            // for debugging purposes
            if (Input.GetKey("m")) {
                TakeDamages(1);
                Debug.Log(hp);
            }

            controller.Move(velocity * Time.deltaTime);
        }

    }

    public void TakeDamages (float damages) {
        hp -= (int)damages;
    }

    public void Kill () {
        
        deadCount++;
        Debug.Log(teleportTarget.transform.position);
        Debug.Log(transform.position);
        transform.position=teleportTarget.transform.position;
        transform.position=teleportTarget.transform.position;
        collect.GetComponent<collectReviveItem>().setItemCount();
        hp=100;
        Debug.Log(collect.GetComponent<collectReviveItem>().getItemCount());
        
    }
}
