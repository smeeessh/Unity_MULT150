using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float health = 1004;
        float poisonDamage = 125.5f;
        while(health > 0)
        {
            health -= poisonDamage;
            Debug.Log(health);
        }
        if (health == 0)
        {
            Debug.Log("Player has Unalived");
        }
    }
}
