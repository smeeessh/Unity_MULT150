using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mX = Input.GetAxis("Horizontal") / 100;
        float mY = Input.GetAxis("Vertical") / 100;
        transform.Translate(mX, mY, 0);
    }
}
