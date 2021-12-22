using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Mouse : MonoBehaviour
{

    public int ogWill = 100;
    public int hp = 100;
    public int will;
    public int deadCount = 0;
    public GameObject mouse;
    public Transform teleportTarget;
    public GameObject collect;

    void Start()
    {
        will = ogWill;
    }

    void Update () {
        if(Input.GetKey("m")) {
           TakeDamages(1);
           Debug.Log(hp);
        }
        if (hp <= 0 && collect.GetComponent<collectReviveItem>().getItemCount()>0) {
            Debug.Log("OUOUUOUOUOUOUOUOU");
            Respawn();
        }
    }

    public void TakeDamages (int damages) {
        hp -= damages;
    }

    private void Respawn () {
        
        deadCount++;
        Debug.Log(teleportTarget.transform.position);
        Debug.Log(mouse.transform.position);
        mouse.transform.position=teleportTarget.transform.position;
        mouse.transform.position=teleportTarget.transform.position;
        collect.GetComponent<collectReviveItem>().setItemCount();
        hp=100;
        Debug.Log(collect.GetComponent<collectReviveItem>().getItemCount());
        
    }
}
