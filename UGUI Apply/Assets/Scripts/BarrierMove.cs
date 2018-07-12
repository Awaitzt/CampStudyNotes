using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BarrierMove : MonoBehaviour {
    private GameObject _barrier;
    private Text _text;
    private float _speed = 5f;
    private GameObject _player;
    // Use this for initialization
    void Start()
    {
        _barrier = gameObject;
        _player = GameObject.FindWithTag("Player");
        _text = GameObject.Find("GameOver").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * _speed * Time.deltaTime;
        if (transform.position.z >= 17.5)
            Destroy(_barrier);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == _player)
        {
            Destroy(_player);
            _text.text = "Game over!";
        }
    }
}
