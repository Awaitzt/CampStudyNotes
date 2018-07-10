using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    private float _X;
    private float _Y;
    private float _Z;
    public GameObject _player;
	// Use this for initialization
	void Start () {
        _X = transform.position.x;
        _Y = transform.position.y-_player.transform.position.y;
        _Z = transform.position.z - _player.transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(_X,_Y+_player.transform.position.y,_Z+_player.transform.position.z);
	}
}
