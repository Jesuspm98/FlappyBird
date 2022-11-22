using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reposition : MonoBehaviour
{
    public float finalX = -15;
    public float initialX = 15;

    public float maxY = 3;
    public float minY = -3;

    public bool isPalallax;

    private void Start()
    {
        if (!isPalallax)
        {
            float rand = Random.Range(minY, maxY);
            SetNewPosition(transform.position.x, rand);
        }
    }

    private void Update()
    {
        if (transform.position.x < finalX)
        {
            if (!isPalallax)
            {
                float rand = Random.Range(minY, maxY);
                SetNewPosition(initialX, rand);
            }
            else
            {
                SetNewPosition(initialX, transform.position.y);
            }
        }
    }

    public void SetNewPosition(float x, float y)
    {
        transform.position = new Vector3(x, y, 0);
    }
}