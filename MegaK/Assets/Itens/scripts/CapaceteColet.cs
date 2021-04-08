using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapaceteColet : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Player2")
        {

            other.gameObject.GetComponent<KartControl>().Cquantidade++;
            Destroy(gameObject, 0.1f);
        }

    }
}


