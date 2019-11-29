using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimerDemo : MonoBehaviour
{
    float lastPressTime = 0f;
    float currPressTime = 0f;

    float dTime = 0f;

    void Update()
    {
        // Checks if any key has been pressed
        if (Input.anyKeyDown)
        {
            // Staggers presstimes, lastPressTime takes the value of currPressTime and currPressTime takes the value of the current time.
            lastPressTime = currPressTime;
            currPressTime = Time.time;
            // dTime, or delta time
            dTime = (currPressTime - lastPressTime);
            // Logs difference, as well as current time to console.
            Debug.Log("Time since start: " + Time.time + " Time between keypreeses: " + dTime);
        }

    }

}
