using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFitterScript : MonoBehaviour
{
    [SerializeField]
    private GameObject placableObjectPrefab;

    private Vector3 currentEulerAngles;

    private int counter = 0;

    private GameObject currentPlacableObject;
    public Transform parent;

    void Start() 
    {
        parent = GameObject.FindWithTag("Parent").transform;  
    }
    private void Update() 
    {
       
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if(Input.GetMouseButtonDown(1))
        {
            if(counter ==0)
            {
                if(Physics.Raycast(ray, out hitInfo))
                {
                  currentPlacableObject =  Instantiate(placableObjectPrefab, hitInfo.point, Quaternion.FromToRotation(Vector3.up, hitInfo.normal), parent);
                    counter++;
                }
            }else if(counter == 1)
            {
                currentPlacableObject = null;
                counter = 0;
            }
        }
    }
    
   /* private void ReleaseIfClicked()
    {
        if(Input.GetMouseButtonDown(0))
        {
            currentPlacableObject = null;
        }
    }

    private void moveCurrentPlacableObjectToMouse()
    {
       
        if(Physics.Raycast(ray, out hitInfo))
        {
            currentPlacableObject.transform.position = hitInfo.point;
            currentPlacableObject.transform.rotation = Quaternion.FromToRotation(Vector3.up, hitInfo.normal);
        }
    }

    private void HandleNewObjectHotKey()
    {
        if(Input.GetKeyDown(newObjectHotKey))
        {
                if(currentPlacableObject == null)
                {
                    currentPlacableObject = Instantiate(placableObjectPrefab);
                }else
                {
                    Destroy(currentPlacableObject);
                }
        }
    }
    */
    public void ObjectSetter(GameObject go)
    {
        placableObjectPrefab = go;
    }
    
    public void Rotator(int x, int y, int z)
    {
        currentEulerAngles += new Vector3(x,y,z);
        currentPlacableObject.transform.Rotate(currentEulerAngles, Space.World);
        
    }

    public void ObjectScaler(float scale)
    {
        Vector3 scaler = currentPlacableObject.transform.localScale;
        scaler.x = scale;
        scaler.y = scale;
        scaler.z = scale;
        currentPlacableObject.transform.localScale = scaler;

    }
}
