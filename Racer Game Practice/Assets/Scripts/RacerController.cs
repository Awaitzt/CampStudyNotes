using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacerController : MonoBehaviour {
    private float _speed=0f;
    private float _acceleration=5f;
    private float _breakAcceleration = 5f;
    public float _rotateSpeed=45f;
    public float _maxSpeed=25f;
    private float _backMaxSpeed = 15f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow)&&_speed!=0)
            transform.Rotate(Vector3.down*_rotateSpeed*Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow) && _speed != 0)
            transform.Rotate(Vector3.up * _rotateSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if(_speed<0)
                _speed += _breakAcceleration * Time.deltaTime;
            else if (_speed < _maxSpeed)
                _speed += _acceleration * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if(_speed>0)
                _speed-= _breakAcceleration * Time.deltaTime;
            else if (_speed > -_maxSpeed)
                _speed -= _acceleration * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow) == false && Input.GetKey(KeyCode.DownArrow) == false&&_speed!=0)
        {
            if (_speed > 0)
            {
                if (_speed - _acceleration * Time.deltaTime >= 0)
                    _speed -= _acceleration * Time.deltaTime;
                else
                    _speed = 0;
            }
            else
            {
                if (_speed + _acceleration * Time.deltaTime <= 0)
                    _speed += _acceleration * Time.deltaTime;
                else
                    _speed = 0;
            }
        }
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }
}
