﻿using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

public class Player2Rotate : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) // aim Left
            transform.rotation = Quaternion.Euler(0, 0, 90);

        if (Input.GetKey(KeyCode.D)) // aim Right
            transform.rotation = Quaternion.Euler(0, 0, 270);

        if (Input.GetKey(KeyCode.W)) // aim Up
            transform.rotation = Quaternion.Euler(0, 0, 360);

        if (Input.GetKey(KeyCode.S)) // aim Down
            transform.rotation = Quaternion.Euler(0, 0, 180);

    }
}
