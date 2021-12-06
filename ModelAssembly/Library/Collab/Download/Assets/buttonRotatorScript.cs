using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonRotatorScript : MonoBehaviour
{
    private int x = 0;
    private int y = 0;
    private int z = 0;

    private GameObject player;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }
   public void ButX(){
        x = 90;
        player.GetComponent<ObjectFitterScript>().Rotator(x,y,z);
    }
    public void ButY(){
        y = 90;
        player.GetComponent<ObjectFitterScript>().Rotator(x,y,z);
    }
    public void ButZ(){
        z = 90;
        player.GetComponent<ObjectFitterScript>().Rotator(x,y,z);
    }
}
