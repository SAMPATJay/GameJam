using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDetector : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isInside;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Bomb")
        {
            isInside = true;
        } 
    }
    void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "Bomb")
        {
            isInside = true;
        }
    }
    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Bomb")
        {
            isInside = false;
        }
    }
}
