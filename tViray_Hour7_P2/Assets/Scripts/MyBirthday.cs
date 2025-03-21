using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int day = 0;
        while (day < 21)
        {
            day += 1;
            Debug.Log(day);
        }
        Debug.Log("It's my birthday!");
        day += 1;
        while (day < 31)
        {
            day += 1;
            Debug.Log(day);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
