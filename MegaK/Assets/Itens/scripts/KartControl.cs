using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartControl : MonoBehaviour{

    public GameObject tiro;
    public GameObject capacete;
    public Transform kart;
    private float shootVelocity = 8f;
    public int ammo = 0;
    public int Cquantidade = 0;

    private void Update(){

        if (Input.GetKeyDown(KeyCode.Space) && ammo > 0){

            GameObject go = Instantiate(tiro, kart.position + kart.forward * 2, kart.rotation);
            go.GetComponent<Rigidbody>().velocity = kart.forward * shootVelocity;
            go.GetComponent<Collider>().isTrigger = false;
            ammo = 0;
        }
        if (Input.GetKeyDown(KeyCode.Space) && Cquantidade > 0){

            GameObject go = Instantiate(capacete, kart.position + kart.forward * -3, kart.rotation);
            go.GetComponent<Rigidbody>().velocity = kart.forward * shootVelocity;
            go.GetComponent<Collider>().isTrigger = false;
            Cquantidade = 0;
        }

    }


}
