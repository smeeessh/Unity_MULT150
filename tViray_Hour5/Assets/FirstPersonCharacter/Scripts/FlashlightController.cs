using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FlashlightController : MonoBehaviour
{
    private Light Lig;
    // Start is called before the first frame update
    void Start()
    {
       Lig = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown((int)MouseButton.Left) == true)
        {
            Lig.enabled = !Lig.enabled;
        }
    }
}
