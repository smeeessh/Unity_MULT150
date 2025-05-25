using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidable : MonoBehaviour
{

    public GameManager Manager;
    public float moveSpeed = 20;
    public float timeAmount = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, -moveSpeed * Time.deltaTime);
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player")
        {
            Manager.AdjustTime(timeAmount);
            Destroy(gameObject);
        }
    }
}
