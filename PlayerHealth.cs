using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    //return type   name         ref list for function


    // Start is called before the first frame update
    void Start()
    {
        float health = 1004;
        float poisonDamage = 125.5f;
        while (health > 0)
        {
            health -= poisonDamage;
            Debug.Log(health);
        }
        Debug.Log("Player has unalived!");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
