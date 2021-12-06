using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public GameObject explosionPrefab;
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
    public void Kill()
    {
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
