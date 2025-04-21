using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LRTriggerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider other)
    {
        if (transform.position.x != 1.5f)
        {
            print(other.gameObject.name + " has entered LTrigger.");
        }
        else
        {
            print(other.gameObject.name + " has entered RTrigger.");
        }

    }

    void OnTriggerStay(Collider other)
    {
        if (transform.position.x != 1.5f)
        {
            print(other.gameObject.name + " is in LTrigger.");
        }
        else
        {
            print(other.gameObject.name + " is in RTrigger.");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (transform.position.x != 1.5f)
        {
            print(other.gameObject.name + " has left LTrigger.");
        }
        else
        {
            print(other.gameObject.name + " has left RTrigger.");
        }
    }
}
