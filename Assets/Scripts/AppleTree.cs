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
        //Changing Direction
    }
}
