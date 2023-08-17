using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObj : MonoBehaviour
{
    //For Auto-Rotation.
    public Vector3 _rotation;
    public float _speed;
    //public float rotationSpeed;
    public void Update()
    {
        transform.Rotate(_rotation * _speed * Time.deltaTime);
    }

    public void LeftCycle()
    {
        _rotation = new Vector3(0, 1, 0);

    }
    public void RightCycle()
    {
        _rotation = new Vector3(0, -1, 0);
    }
}
