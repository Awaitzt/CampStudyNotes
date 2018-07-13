using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public GameObject _racer;
    private Vector3 _distance;
    private float _delta = 0.03f;
    //private Vector3 _eulerAngle;
    private float _y;
    private float _dis;
	// Use this for initialization
	void Start () {
        //transform.SetParent(_racer.transform);
        _distance = transform.position - _racer.transform.position;
        _dis = Mathf.Sqrt(Mathf.Pow(_distance.x, 2)+ Mathf.Pow(_distance.z, 2));
        //_eulerAngle = _racer.transform.eulerAngles;
        //Debug.Log(_eulerAngle.y);Transform
        _y = _racer.transform.rotation.y;
        Debug.Log(_y);

    }
	
	// Update is called once per frame
	void Update () {
        _distance.z = _dis * Mathf.Cos(_racer.transform.rotation.y - _y);
        _distance.x = _dis * Mathf.Sin(_racer.transform.rotation.y - _y);
        transform.position = Vector3.Lerp(transform.position, _racer.transform.position + _distance, _delta);
        transform.LookAt(_racer.transform);
    }
}
