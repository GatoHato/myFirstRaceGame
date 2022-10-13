﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyRotate : MonoBehaviour
{
    // Start is called before the first frame update

    public float rotateSpeed = 0.5f;

    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", rotateSpeed * Time.time);
    }
}
