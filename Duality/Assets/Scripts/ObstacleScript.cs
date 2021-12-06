using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{ 
     public float speed;
     public float speedIncrement;
     private float timeBtwInc;
    public float startTimeBtwInc;
    void Update()
    {
        if(timeBtwInc <= 0)
        {
            speed += speedIncrement;
            timeBtwInc = startTimeBtwInc;
        }
        else
        timeBtwInc -= Time.deltaTime;


        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
