using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonRotatorScript : MonoBehaviour
{
    private int x=90;

    private GameObject player;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }
   public void ButX(){
        player.GetComponent<ObjectFitterScript>().Rotator(x,0,0);
    }
    public void ButY(){
        player.GetComponent<ObjectFitterScript>().Rotator(0,x,0);
    }
    public void ButZ(){
        player.GetComponent<ObjectFitterScript>().Rotator(0,0,x);
    }
}
