﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingWallScript : MonoBehaviour {

    private float startRot;
    private float endRot;
    private float currentRot;
    private bool returnRot;

    void Start ()
    {
        startRot = transform.rotation.eulerAngles.z;
              

        endRot = startRot + 180;

    }


    void Update()
    {
        currentRot = transform.rotation.eulerAngles.z;


        if(returnRot == false && (currentRot > endRot + 2 || currentRot < endRot - 2))
        {
            transform.RotateAround(transform.parent.position, Vector3.back, 45 * Time.deltaTime);
        }
        else
        {
            returnRot = true;
        }



        if (returnRot == true && (currentRot < startRot + 2 || currentRot > endRot - 2))
        {
            print("wow");
            transform.RotateAround(transform.parent.position, Vector3.forward, 45 * Time.deltaTime);
        }
        else
        {
            returnRot = false;
        }






    }
}
