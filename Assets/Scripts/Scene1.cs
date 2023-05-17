using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class Scene1 : MonoBehaviour
{
    public static float top = 10;
    public static float bottom = -10;
    public static float left = -10;
    public static float right = 10;

    // Start is called before the first frame update
    void Start()
    {
        GameObject spritePrefab = (GameObject)Resources.Load("Prefabs/MovingSprite", typeof(GameObject));

        Instantiate(spritePrefab, new Vector2(0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
