using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class Scene2 : MonoBehaviour
{
    float[,] initialPositions = new float[5, 2] { { -10, 0 }, { -5, 0 }, { 0, 0 }, { 5, 0 }, { 10, 0 } };

    // Start is called before the first frame update
    void Start()
    {
        GameObject flowerPrefab = (GameObject)Resources.Load("Prefabs/RotatingSprite", typeof(GameObject));

        //for (; ; )
        //{
            Instantiate(flowerPrefab, new Vector2(initialPositions[1, 0], initialPositions[1, 1]), Quaternion.identity);
        //}
    }

    // Update is called once per frame
    void Update()
    {
    }

}
