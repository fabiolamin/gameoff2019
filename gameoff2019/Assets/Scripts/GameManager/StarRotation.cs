using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarRotation : MonoBehaviour
{
    private Transform transform;
    float speed = 50f;
    void Start()
    {
        transform = GetComponent<Transform>();
    }
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime *speed);
    }
}
