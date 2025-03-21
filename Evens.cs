using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int two = 20;
        while (two < 100)
        {
            two += 2;
            Debug.Log(two);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
