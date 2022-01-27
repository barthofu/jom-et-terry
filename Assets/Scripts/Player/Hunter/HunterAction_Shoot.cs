using UnityEngine;

public class HunterAction_Shoot : MonoBehaviour {

    public int damages = 10;
    public float range = 100f;

    public ParticleSystem spray;
    public ParticleSystem gas;

    void Update() {

        if (Input.GetButtonDown("Fire1")) {
            spray.Play();
            gas.Play();
            Shoot();
        }
        else if (Input.GetButtonUp("Fire1")) {
            spray.Stop();
            gas.Stop();
        }
    }

    void Shoot() {


    }

    void Old_Shoot () {

        RaycastHit hit;
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, range)) {
            //on touche quelque chose
            Mouse mouse = hit.transform.gameObject.GetComponent<Mouse>();
            if (mouse) mouse.TakeDamages(damages);
        }
    }
}
