using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    public float dist;
    private void Start()
    {
        StartCoroutine(RayCoroutine());
    }

    IEnumerator RayCoroutine()
    {
        while (true) 
        {
            yield return new WaitForSeconds(0.001f);
            CreateRay();
            
        }
    }
    private void CreateRay() 
    { 
        Ray ray = new Ray(transform.position,transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            dist = hit.distance;
            Debug.Log("Датчик: "+ gameObject.name + " Координаты точки: "+ hit.point +" Дистанция до точки: " +hit.distance);
        }
    }
}
