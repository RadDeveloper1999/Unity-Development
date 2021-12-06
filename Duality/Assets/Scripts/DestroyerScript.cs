using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerScript : MonoBehaviour
{
    public float time;
    void Update()
    {
        Destroy(gameObject, time);
    }
}
