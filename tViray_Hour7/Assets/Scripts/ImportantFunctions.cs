using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImportantFunctions : MonoBehaviour
{
    // Found in public class, can be referenced anywhere
    private int num1;
    public int runSpeed;
    // Start is called before the first frame update
    void Start()
    {
        // local to start, can only be used in start
        int num2;
        print("Start runs before an object updates");
    }

    // Update is called once per frame
    void Update()
    {
        print("This is called once per frame");
    }
}
