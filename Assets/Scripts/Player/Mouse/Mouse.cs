using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : Player, IDamageable, IKillable {

    public int ogWill = 100;
    public int will;

    public Transform teleportTarget;
    public GameObject collect;
    public GameObject hpParticle;

	public Vector3 defaultForce = new Vector3(0f,1f,0f);
	public float defaultForceScatter = 0.5f;

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

    void OnParticleCollision(GameObject other) {
        
        if (other.tag == "Spray") 
            TakeDamages(1f);
    }

    public void TakeDamages (float damages) {

        hp -= (int)damages;

        GameObject newHp = Instantiate(hpParticle, transform.position, transform.rotation) as GameObject;
        newHp.GetComponent<AlwaysFace>().Target = Camera.main.gameObject;

        TextMesh textMesh = newHp.transform.Find("HPLabel").GetComponent<TextMesh>();
        textMesh.text = string.Format("{0:N0}", damages);

        newHp.GetComponent<Rigidbody>().AddForce(new Vector3(defaultForce.x + Random.Range(-defaultForceScatter,defaultForceScatter),defaultForce.y + Random.Range(-defaultForceScatter,defaultForceScatter),defaultForce.z + Random.Range(-defaultForceScatter,defaultForceScatter)));
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
