using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjNoCap : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(2, Time.deltaTime, 1, Space.World);
    }


    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

}
