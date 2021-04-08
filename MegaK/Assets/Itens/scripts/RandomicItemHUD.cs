using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomicItemHUD : MonoBehaviour
{
    public Canvas HUD;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            HUD.GetComponent<HudScript>().ItemDisponivel(0);


        }
    }
}
