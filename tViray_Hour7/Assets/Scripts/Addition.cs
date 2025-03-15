using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 2;
        int b = 4;
        int c = 8;
        int sum = a + b + c;
        sum++;
        Debug.Log(sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
