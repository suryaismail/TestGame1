using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Rigidbody))]

public class RotatePlayer : MonoBehaviour
{
    private float rotationSpeed = -50f;
    private float movementSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(0, 0, Time.deltaTime * rotationSpeed * horizontal);

        float vertical = Input.GetAxis("Vertical");

        transform.position += transform.up * Time.deltaTime * movementSpeed * vertical;

    }
}
