using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BasicMover : MonoBehaviour
{
    public float spinSpeed = 180.0f;
    private bool grow = true;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
    }
}
