using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudScript : MonoBehaviour
{
    public Image item;
    //public bool itemcoletado = false;
    public List<Sprite> images = new List<Sprite>();
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    { 

        

            //ItemDisponivel(0);
            


        
    }

    public void ItemDisponivel(int qualItem)
    {
        item.GetComponent<Image>().color = new Color(1, 1, 1, 1);
        item.GetComponent<Image>().sprite = images[qualItem];
        

    }
    public void ItemIndisponivel()
    {
        item.GetComponent<Image>().color = new Color(1, 1, 1, 0);
        item.GetComponent<Image>().sprite = null;

    }
    // Update is called once per frame
   /* void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            bool item = itemcoletado = true;
            if (item)
            {

            }
                
        }
    }*/
}
