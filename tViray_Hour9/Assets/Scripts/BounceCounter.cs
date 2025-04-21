using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    int bounces = 0;

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
        bounces += 1;
        if (bounces == 1)
        {
            print(bounces + " bounce");
        } else
        {
            print(bounces + " bounces");
        }

    }

}
