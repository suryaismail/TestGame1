using UnityEngine;
using System.Collections;

public class ButtonUI : MonoBehaviour
{

    public void AddFlower()
	{
        GameObject flowerPrefab = (GameObject)Resources.Load("Prefabs/RotatingSprite", typeof(GameObject));

        System.Random rand = new System.Random();
        Instantiate(flowerPrefab, new Vector2(rand.Next(-10, 10), rand.Next(-5, 5)), Quaternion.identity);
    }

    public void SpeedUpCircle()
    {
        MovingSprite circle = GameObject.FindGameObjectWithTag("circle").GetComponent<MovingSprite>();
        circle.setXStep(circle.getXStep() * 2);
    }

}

