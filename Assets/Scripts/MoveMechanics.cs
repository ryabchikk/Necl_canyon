using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;


public class MoveMechanics : MonoBehaviour
{
    public float speedRotate;
    public float Angle;
    public float speed;

    private CharacterController _characterController;
    
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }
    
    void Update()
    {
        Move();
        RotateCar();
    }

    void CalcAngle()
    {
        while (Angle < 0)
            Angle += 360.0f;
        while (Angle > 360.0)
            Angle -= 360.0f;
        Debug.Log("Angle = " + Angle);
    }

    private void Move() 
    {
        Vector3 _moveVector;
        _moveVector = Vector3.zero;
        _moveVector += transform.right * speed;
        _characterController.Move(_moveVector * Time.deltaTime);
    }
    
    private void RotateCar() 
    {
        transform.rotation =Quaternion.Lerp(transform.rotation,Quaternion.Euler(0, Angle, 0),speedRotate);
        //transform.rotation = Quaternion.Euler(0, Angle, 0);
    }
}
