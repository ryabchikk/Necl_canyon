using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSensor : MonoBehaviour
{
    public Transform pointer;
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position,transform.forward*100f,Color.yellow);
        RaycastHit hit;
        if (Physics.Raycast(ray,out hit)) 
        {
            //pointer.position = hit.point;
            Debug.Log(hit.point);
        }
    }
}
