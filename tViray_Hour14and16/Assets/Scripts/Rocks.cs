using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocks : MonoBehaviour
{
    private int rocks = 0;
    public GameObject rock;
    private Vector3 throwForce;
    private float throwTimer = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RockThrow();
    }
    void RockThrow()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            rocks += 1;
        }

        if (Input.GetButtonDown("Fire2") && rocks > 1)
        {
            rocks -= 1;
            throwForce = new Vector3(1, 50, 300);
            var ri = Instantiate(rock, new Vector3(0.5f, 1, -10), transform.rotation);

            ri.GetComponent<Rigidbody>().AddForce(throwForce);
        }
        if (throwTimer > 0)
        {
            rock.GetComponent<Rigidbody>().AddForce(throwForce * Time.deltaTime);
        }
    }
}
