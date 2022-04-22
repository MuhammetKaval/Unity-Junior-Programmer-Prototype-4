using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePowerupIndicator : MonoBehaviour
{
    public float speed = 180.0f;

    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
