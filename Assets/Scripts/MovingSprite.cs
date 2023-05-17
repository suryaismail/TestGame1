using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSprite : MonoBehaviour
{
    float xStep = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        if (position.x > Player.right){
            xStep = -xStep;
        }
        position.x = position.x + xStep;

        transform.position = position;
    }
}
