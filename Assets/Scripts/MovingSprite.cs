using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSprite : MonoBehaviour
{
    float xStep = 1f;

    public float getXStep()
    {
        return xStep;
    }

    public void setXStep(float xStep)
    {
        this.xStep = xStep;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        if ((position.x > Scene1.right) || (position.x < Scene1.left))
        {
            xStep = -xStep;
        }
        position.x += xStep * Time.deltaTime;

        transform.position = position;
    }
}
