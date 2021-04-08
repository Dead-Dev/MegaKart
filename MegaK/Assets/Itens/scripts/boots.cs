using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boots : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Time.deltaTime, 2, Space.World);
    }


    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

}
