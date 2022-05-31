using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorController : MonoBehaviour
{
    [SerializeField] Sensor[] sensors;
    public float[] masDist;
    void Update()
    {
        for (int i = 0; i < sensors.Length; i++) 
        { 
            masDist[i] = sensors[i].dist;
        }
    }
}
