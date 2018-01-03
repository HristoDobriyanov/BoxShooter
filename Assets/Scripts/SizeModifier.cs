using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SizeModifier : MonoBehaviour
{
    
    private bool grow = true;

    // Update is called once per frame
    void Update()
    {
        Vector3 resize = transform.localScale;

        if (grow)
        {
            resize = resize * 1.03f;
        }
        else
        {
            resize = resize * 0.97f;
        }

        if (resize.x > 5 || resize.x < 1)
        {
            grow = !grow;
        }

        transform.localScale = resize;
    }
}
