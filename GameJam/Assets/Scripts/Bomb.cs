using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float timerTime;
    public GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(parent, timerTime + 0.1f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }


    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Breakable")
        {
            Destroy(other.gameObject, timerTime);
        }
        if (other.gameObject.tag=="Player"&& GameObject.FindGameObjectWithTag("Player").GetComponent<BombDetector>().isInside == true)
        {
            Destroy(other.gameObject, timerTime);
        }
        if (other.gameObject.tag == "Enemy" /*&& GameObject.FindGameObjectWithTag("Enemy").GetComponent<BombDetector>().isInside == true*/)
        {
            Destroy(other.gameObject, timerTime);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<BombDetector>().isInside = false;
        }
        if (other.gameObject.tag == "Enemy")
        {
            //GameObject.FindGameObjectWithTag("Enemy").GetComponent<BombDetector>().isInside = false;
        }
    }

}
