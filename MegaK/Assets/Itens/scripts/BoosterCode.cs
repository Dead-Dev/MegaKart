using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterCode : MonoBehaviour
{
   void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Player2"){

            other.gameObject.GetComponent<KartControl>().ammo++;
            Destroy(gameObject, 0.1f);
        }

    }
}
