using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private GameObject Camera;

    // Start is called before the first frame update
    void Start()
    {
        Camera = GameObject.FindWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        float MxVal = Input.GetAxis("Mouse X");
        float MyVal = Input.GetAxis("Mouse Y");

        //mouse x movement
        if (MxVal < 0)
        {
            transform.Translate(-.1f, 0f, 0f);
        }
        else if (MxVal > 0)
        {
            transform.Translate(.1f, 0f, 0f);
        }
        
        //mouse y movement
        if (MyVal < 0)
        {
            transform.Translate(0f, -.1f, 0f);
        }
        else if (MyVal > 0)
        {
            transform.Translate(0f, .1f, 0f);
        }
    }
}
