using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("References")]
    public GameManager manager;
    public Material normalMat;
    public Material phasedMat;

    [Header("Gameplay")]
    public float bounds = 3;
    public float strafeSpeed = 4;
    public float phaseCooldown = 2;

    Renderer mesh;
    Collider Collision;
    bool canPhase = true;
    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponentInChildren<SkinnedMeshRenderer>();
        Collision = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal") * Time.deltaTime * strafeSpeed;

        Vector3 position = transform.position;
        position.x += xMove;
        position.x = Mathf.Clamp(position.x, -bounds, bounds);
        transform.position = position;

        if (Input.GetButtonDown("Jump") && canPhase)
        {
            canPhase = false;
            mesh.material = phasedMat;
            Collision.enabled = false;

            Invoke("PhaseIn", phaseCooldown);
        }

    }
        void PhaseIn()
        {
            canPhase = true;
            mesh.material = normalMat;
            Collision.enabled = true;
        }
}
