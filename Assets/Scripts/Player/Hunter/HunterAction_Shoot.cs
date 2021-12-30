using UnityEngine;

public class HunterAction_Shoot : MonoBehaviour {

    public int damages = 10;
    public float range = 100f;

    void Update() {

        if (Input.GetButtonDown("Fire1"))
            Shoot();
    }

    void Shoot () {

        RaycastHit hit;
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, range)) {
            //on touche quelque chose
            Mouse mouse = hit.transform.gameObject.GetComponent<Mouse>();
            if (mouse) mouse.TakeDamages(damages);
        }
    }
}
