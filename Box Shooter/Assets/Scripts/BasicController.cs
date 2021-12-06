using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class BasicController : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        UnityEngine.Debug.Log("Horizontal Input = " + Input.GetAxis("Horizontal"));
    }
}
