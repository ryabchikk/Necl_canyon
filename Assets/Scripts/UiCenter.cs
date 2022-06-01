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
    [SerializeField] private GameObject car;

    private MoveMechanics MVCar;
    private void Start()
    {
        MVCar = car.GetComponent<MoveMechanics>();
    }
    
    private void Update()
    {
        DemonstratePositionCar();
        DemostrateSpeedCar();
        DemostrateAngleCar();
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
    public void LoadLevel(int level)
    {
        SceneManager.LoadScene(level);
        Time.timeScale = 1;
    }
}
