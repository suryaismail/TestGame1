using System.Collections;
using System.Collections.Generic;
using static System.Math;
using UnityEngine;

public class RotateMovingPlayer : MonoBehaviour
{
    private float rotationSpeed = -50f;
    private float movementSpeed = 1f;

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
        movementSpeed = System.Math.Max(movementSpeed + vertical / 10f, 0);

        transform.position += transform.up * Time.deltaTime * movementSpeed;

    }
}