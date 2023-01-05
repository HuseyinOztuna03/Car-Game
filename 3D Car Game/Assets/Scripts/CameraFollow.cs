using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform car;
    Vector3 remainder;

    void Start()
    {
        remainder = transform.position - car.position;
    }

    void Update()
    {
        transform.position = car.position + remainder;
    }
}
