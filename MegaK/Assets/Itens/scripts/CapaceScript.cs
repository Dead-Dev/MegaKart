using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapaceScript : MonoBehaviour
{
    
    bool collided;

    IEnumerator OnTriggerEnter(Collider Capacete)
    {
        collided = true;
        yield return new WaitForSeconds(1f);
        if (collided)
        {
            Destroy(gameObject, 0.5f);
        }
    }

    void OnCollisionExit()
    {
        collided = false;
    }

    
}
