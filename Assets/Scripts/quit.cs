using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("quit"))// detects when the player presses esc
        {
            Application.Quit();// quits game
        }
    }
}
