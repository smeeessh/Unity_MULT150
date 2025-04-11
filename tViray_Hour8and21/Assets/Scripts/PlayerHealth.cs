using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    int healthPoints = 3992;
    // Start is called before the first frame update
    void Start()
    {
        healthPoints = UsePotion(healthPoints);
        Debug.Log(healthPoints);
        healthPoints = UsePotion(healthPoints);
        Debug.Log(healthPoints);
        healthPoints = UsePotion(healthPoints);
        Debug.Log(healthPoints);
        healthPoints = UsePotion(healthPoints);
        Debug.Log(healthPoints);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int UsePotion(int health)
    {
        health += 400;
        return health;
    }
}
