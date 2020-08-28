﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotAngle = 4.0f;

    private void FixedUpdate()
    {
        transform.Rotate(0f, -rotAngle, 0f); //左回転
    }
}
