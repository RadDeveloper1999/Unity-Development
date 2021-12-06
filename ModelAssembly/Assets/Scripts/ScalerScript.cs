using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScalerScript : MonoBehaviour
{
    public InputField scaleInput;
    string scaleNum;
    float scaleValue;
    private GameObject player;
    // Update is called once per frame
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }
    void Update()
    {
     scaleNum = scaleInput.text; 
     scaleValue = float.Parse(scaleNum);
    }

    public void ScaleButton()
    {
        player.GetComponent<ObjectFitterScript>().ObjectScaler(scaleValue);
    }
}
