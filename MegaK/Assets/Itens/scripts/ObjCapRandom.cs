using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjCapRandom : MonoBehaviour
{
    // Start is called before the first frame update

    public List<GameObject> myObjects;
    public GameObject obj_random;
    void Start()
    {
        int randomNumber = Random.Range(0, myObjects.Count);
        Instantiate(myObjects[randomNumber], obj_random.transform.position, Quaternion.identity);

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
