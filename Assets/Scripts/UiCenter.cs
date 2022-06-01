using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
public class UiCenter : MonoBehaviour
{
    [SerializeField] private Text textPos;
    [SerializeField] private Text textSpeed;
    [SerializeField] private Text textAngle;
    [SerializeField] private Text textSensorsDist;
    [SerializeField] private GameObject car;
    [SerializeField] Sensor[] sensors;
    
    private float[] mas;
    private MoveMechanics MVCar;
    private void Start()
    {
        MVCar = car.GetComponent<MoveMechanics>();
        mas = new float[sensors.Length];
    }
    
    private void Update()
    {
        DemonstratePositionCar();
        DemostrateSpeedCar();
        DemostrateAngleCar();
        DemonstrateDistSensors();
    }
    
    public void DemonstratePositionCar() 
    {
        textPos.text = (car.transform.position).ToString();
    }
    
    public void DemostrateSpeedCar() 
    {
        textSpeed.text = Math.Round(MVCar.speed).ToString();
    }

    public void DemostrateAngleCar()
    {
        textAngle.text = Math.Round(MVCar.Angle).ToString();
    }
    public void DemonstrateDistSensors() 
    {
        string s = "(";
        for (int i = 0; i < sensors.Length; i++)
        {
            mas[i] = sensors[i].dist;
            if (mas[i] >= 15) 
            {
                s += "Nan,";
            }
            else 
            {
                s += Math.Round(mas[i]).ToString() + ",";
            }
        }
        s += ")";
        textSensorsDist.text = s;


    }
    public void LoadLevel(int level)
    {
        SceneManager.LoadScene(level);
        Time.timeScale = 1;
    }
    public void StopTime() 
    {
        Time.timeScale = 0;
    }
}
