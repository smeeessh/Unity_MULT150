using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hVal = Input.GetAxis("Horizontal");
        float vVal = Input.GetAxis ("Vertical");
        float MxVal = Input.GetAxis("Mouse X");
        float MyVal = Input.GetAxis("Mouse Y");
        //wasd movement
        if (hVal !=0)
        {
            print("Horizontal movement selected" + hVal);
        }
        if (vVal != 0)
        {
            print("Vertical movement selected" + vVal);
        }

        //mouse movement
        if (MxVal != 0)
        {
            print("Mouse X movement selected" + hVal);
        }
        if (MyVal != 0)
        {
            print("Mouse Y movement selected" + vVal);
        }

        //m or o keys pressed
        if (Input.GetKey(KeyCode.M))
        {
            print("The 'M' key is pressed");
        }
        if (Input.GetKey(KeyCode.O))
        {
            print("The 'O' key is pressed");
        }
    }
}
