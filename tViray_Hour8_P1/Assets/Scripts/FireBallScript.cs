using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallScript : MonoBehaviour
{
    int TakeDamageFromFireball1()
    {
        int playerhealth = 100;
        return playerhealth - 5;
    }

    int TakeDamageFromFireball2 (int damage)
    {
        int playerhealth = 100;
        return playerhealth - damage;
    }

    int TakeDamageFromFireball3 (int damage, int playerHealth)
    {
        return playerHealth - damage;
    }
    // Start is called before the first frame update
    void Start()
    {
        int x = TakeDamageFromFireball1();
        print("Player Health:" + x);

        int y = TakeDamageFromFireball2(25);
        print("Player Health" + y);

        int z = TakeDamageFromFireball3(30, 50);
        print("Player Health" + z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
