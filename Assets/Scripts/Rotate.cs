using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Defines the axis and the speed of rotation")]
    private Vector3 _rotation = new Vector3(0, 90, 0);
    void Update()
    {
        transform.Rotate(_rotation * Time.deltaTime);
    }
}
