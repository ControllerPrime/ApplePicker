using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour {
    [Header("Set in Inspector")]

    public GameObject applePrefab;

    public float speed = 1f;

    public float leftAndRightEdge = 10f;

    public float changeToChangeDirections = 0.1f;

    public float secondsBetweenAppleDrops = 1f;

    private void Start()
    {
        //Dropping apples every second
    }

    private void Update()
    {
        //Basic Movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        //Changing Direction
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); //Move Right
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); //Move left
        }
    }
    private void FixedUpdate()
    {
        if (Random.value < changeToChangeDirections)
        {
            speed *= -1; //Change Directions
        }
    }
}
