using UnityEngine;
using System.Collections;
using System;

public class movingBackground : MonoBehaviour {

    public Material bgA, bgB, bgC;

    private MeshRenderer renderer;

    public float scrollSpeed;
    public float tileSizeZ;
    
    private Vector3 startPosition;

    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        startPosition = transform.position;

        System.Random rand = new System.Random();
        int randomBG = rand.Next(3);

        switch (randomBG)
        {
            case 0: renderer.material = bgA; break;
            case 1: renderer.material = bgB; break;
            case 2: renderer.material = bgC; break;
        }
    }

    void Update()
    {
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);
        transform.position = startPosition + Vector3.left * newPosition;
    }
}