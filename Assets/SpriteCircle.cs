using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteCircle : MonoBehaviour
{
    float XStep = 0.01f;
    yStep = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        position.x = position.x + xStep;
        position.y = position.y + yStep;
        transform.position = position;
    }
}
