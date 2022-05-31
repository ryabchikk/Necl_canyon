using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorController : MonoBehaviour
{
    [SerializeField] Sensor[] sensors;
    [SerializeField] GameObject car;
    public float[] masDist;
    public float speed;
    private void Start()
    {
        masDist = new float[sensors.Length];
    }
    void Update()
    {
        for (int i = 0; i < sensors.Length; i++) 
        { 
            masDist[i] = sensors[i].dist;
        } 
    }
}
