using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
    private float _rotateSpeed = 90f;
    private int _pos=0;
    private int _t1=9, _t2=9;
    private int _jumpState=0;
    public Rigidbody _rig;
    private float _force = 220f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        //控制角色左右移动
        if (Input.GetKeyDown(KeyCode.LeftArrow) && _pos != -1)
        {
            _t1 = 0;
            _pos--;
        }
        if (_t1 < 9)
        {
            transform.Translate(Vector3.left * 0.1f);
            _t1++;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && _pos != 1)
        {
            _t2 = 0;
            _pos++;
        }
        if (_t2 < 9)
        {
            transform.Translate(Vector3.right * 0.1f);
            _t2++;
        }
        //控制角色跳跃
        if (Input.GetKeyDown(KeyCode.Space)&& _jumpState==0)
        {
            _jumpState = 1;
            _rig.AddForce(Vector3.up*_force);
        }
        if (_jumpState == 1 && _rig.velocity.y == 0)
        {
            _jumpState = 0;
        }
    }
}
