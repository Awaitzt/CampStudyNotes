using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    public static int _score = 0;
    private Text _text;
    private GameObject _cube;
    private float _rotaetSpeed=90f;
    private Transform _playerPos;
    private float _speed = 5f;
    // Use this for initialization
    void Start () {
        _cube = gameObject;
        _playerPos = GameObject.FindWithTag("Player").transform;
        _text = GameObject.FindWithTag("Text").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up*_rotaetSpeed*Time.deltaTime);
        transform.position+=Vector3.forward*_speed*Time.deltaTime;
        if (Mathf.Abs(_playerPos.position.x - transform.position.x) <= 0.2 && Mathf.Abs(_playerPos.position.y - transform.position.y) <= 0.2 && Mathf.Abs(_playerPos.position.z - transform.position.z) <= 0.2)
        {
            Destroy(_cube);
            _text.text="Your Score:"+(++_score);
        }
        if (transform.position.z >= 17)
            Destroy(_cube);
    }
}
