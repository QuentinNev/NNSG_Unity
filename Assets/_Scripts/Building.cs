using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public Vector3 defaultPosition;
    void Awake()
    {
        // Cache building position
        defaultPosition = transform.position;

        // Move it underground to make it appear
        // Transform.position properties are read only so we must give it a new Vector3
        Vector3 pos = transform.position;
        pos.y -= 20;
        transform.position = pos;
    }

    void Update()
    {
        
    }
}
