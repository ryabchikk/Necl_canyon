using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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

    private void Move() 
    { 
        Vector3 _moveVector;
        _moveVector = Vector3.zero;
        _moveVector += transform.right * speed;
        _characterController.Move(_moveVector * Time.deltaTime);
    }
    
    private void RotateCar() 
    {
        transform.rotation =Quaternion.Lerp(transform.rotation,Quaternion.Euler(0, Angle, 0),Time.deltaTime* speedRotate);
    }
}
