﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomInput : MonoBehaviour {

    private void OnGUI()
    {
        GUI.Label(new Rect(5.0f, 5.0f, 200.0f, 30.0f), "Horizontal Axis: " + Input.GetAxis("Horizontal"));
        GUI.Label(new Rect(20.0f, 15.0f, 200.0f, 30.0f), "Vertical Axis: " + Input.GetAxis("Vertical"));
    }
}
