using UnityEngine;

public class Gun : MonoBehaviour
{

    public int damage = 10;
    public float range = 100f;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            Shoot();
        } 
    }

    void Shoot () {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, range)) {
            //on touche quelque chose
            GameObject mouse = hit.transform.gameObject;
            MouseMovement mouseMovement = mouse.GetComponent<MouseMovement>();
            if (mouseMovement) {
                mouseMovement.takeDamage(damage);
                Debug.Log("Damage");
            }
        }
    }
}
