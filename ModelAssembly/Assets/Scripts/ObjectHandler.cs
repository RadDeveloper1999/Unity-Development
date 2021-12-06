using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHandler : MonoBehaviour
{
   public GameObject[] stlObjects;
   private int objNum = 0;
   private GameObject random;
    void Start()
    {
        random = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B))
        {
            if(objNum < stlObjects.Length )
            {
                
            ObjectOne(objNum);
            objNum++;
            
            }else{
                objNum = 0;
                ObjectOne(objNum);
            }        
        }   
    }
    public void ObjectOne(int num)
    {
        random.GetComponent<ObjectFitterScript>().ObjectSetter(stlObjects[num]);
    }

    public void But1(){
        objNum = 0;
        ObjectOne(objNum);
        Debug.Log("clicked button 1");
    }
    public void But2(){
        objNum = 1;
        ObjectOne(objNum);
    }
    public void But3(){
        objNum = 2;
        ObjectOne(objNum);
    }
    public void But4(){
        objNum = 3;
        ObjectOne(objNum);
    }
    public void But5(){
        objNum = 4;
        ObjectOne(objNum);
    }
}
