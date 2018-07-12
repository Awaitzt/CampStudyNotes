using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCreatCube : MonoBehaviour
{
    public GameObject _prefabs,_prefab;
    private float _deltaT = 0;
    private float _pos;
    private GameObject _clone;
    private int _jump1=0,_jump2=0,_jump3=0;
    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < 28; i += 3)
        {
            if (_jump1 == 1||_jump1==2)
                _jump1++;
            if (_jump2 == 1 || _jump2 == 2)
                _jump2++;
            if (_jump3 == 1 || _jump3 == 2)
                _jump3++;
            if (Random.Range(0, 8) <= 1 && (_jump1 == 0 || _jump1 == 3))
            {
                _jump1 = 0;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.back * i;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.back * (i + 1);
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.back * (i + 2);
            }
            else if (Random.Range(0, 16) <= 1)
            {
                _jump1++;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.back * i;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.back * (i + 1) + Vector3.down * 0.5f;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.back * (i + 2) + Vector3.down * 1f;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.back * (i + 3) + Vector3.down * 1f;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.back * (i + 4) + Vector3.down * 0.5f;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.back * (i + 5);
            }
            /*else if (Random.Range(0, 8) <= 1)
            {
                _clone = Instantiate(_prefab);
                _clone.transform.position-= Vector3.back * i;
            }*/
            if (Random.Range(0, 8) <= 1 && (_jump2 == 0 || _jump2 == 3))
            {
                _jump2 = 0;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 0.8f + Vector3.back * i;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 0.8f + Vector3.back * (i + 1);
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 0.8f + Vector3.back * (i + 2);
            }
            else if (Random.Range(0, 16) <= 1)
            {
                _jump2++;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 0.8f + Vector3.back * i;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 0.8f + Vector3.back * (i + 1) + Vector3.down * 0.5f;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 0.8f + Vector3.back * (i + 2) + Vector3.down * 1f;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 0.8f + Vector3.back * (i + 3) + Vector3.down * 1f;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 0.8f + Vector3.back * (i + 4) + Vector3.down * 0.5f;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 0.8f + Vector3.back * (i + 5);
            }
            /*else if (Random.Range(0, 8) <= 1)
            {
                _clone = Instantiate(_prefab);
                _clone.transform.position -= Vector3.right * 0.8f + Vector3.back * i;
            }*/
            if (Random.Range(0, 8) <= 1 && (_jump3 == 0 || _jump3 == 3))
            {
                _jump3 = 0;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 2 * 0.8f + Vector3.back * i;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 2 * 0.8f + Vector3.back * (i + 1);
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 2 * 0.8f + Vector3.back * (i + 2);
            }
            else if (Random.Range(0, 16) <= 1)
            {
                _jump3++;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 2 * 0.8f + Vector3.back * i;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 2 * 0.8f + Vector3.back * (i + 1) + Vector3.down * 0.5f;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 2 * 0.8f + Vector3.back * (i + 2) + Vector3.down * 1f;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 2 * 0.8f + Vector3.back * (i + 3) + Vector3.down * 1f;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 2 * 0.8f + Vector3.back * (i + 4) + Vector3.down * 0.5f;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 2 * 0.8f + Vector3.back * (i + 5);
            }
            /*else if (Random.Range(0, 8) <= 1)
            {
                _clone = Instantiate(_prefab);
                _clone.transform.position -= Vector3.right * 2 * 0.8f + Vector3.back * i;
            }*/
        }
        _jump1 = 0;
        _jump2 = 0;
        _jump3 = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        _deltaT++;
        if (_deltaT == 75)
        {
            _deltaT = 0;
            if (_jump1 == 1 || _jump1 == 2)
                _jump1++;
            if (_jump2 == 1 || _jump2 == 2)
                _jump2++;
            if (_jump3 == 1 || _jump3 == 2)
                _jump3++;
            if (Random.Range(0, 8) <= 1 && (_jump1 == 0 || _jump1 == 3))
            {
                _jump1 = 0;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.back * 0;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.back * 1;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.back * 2;
            }
            else if (Random.Range(0, 16) <= 1)
            {
                _jump1++;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.back * 0;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.back * 1 + Vector3.down * 0.5f;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.back * 2 + Vector3.down * 1f;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.back * 3 + Vector3.down * 1f;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.back * 4 + Vector3.down * 0.5f;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.back * 5;
            }
            else if (Random.Range(0, 8) <= 1)
                Instantiate(_prefab);
            if (Random.Range(0, 8) <= 1 && (_jump2 == 0 || _jump2 == 3))
            {
                _jump2 = 0;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 0.8f + Vector3.back * 0;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 0.8f + Vector3.back * 1;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 0.8f + Vector3.back * 2;
            }
            else if (Random.Range(0, 16) <= 1)
            {
                _jump2++;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 0.8f + Vector3.back * 0;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 0.8f + Vector3.back * 1 + Vector3.down * 0.5f;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 0.8f + Vector3.back * 2 + Vector3.down * 1f;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 0.8f + Vector3.back * 3 + Vector3.down * 1f;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 0.8f + Vector3.back * 4 + Vector3.down * 0.5f;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 0.8f + Vector3.back * 5;
            }
            else if (Random.Range(0, 8) <= 1)
            {
                _clone = Instantiate(_prefab);
                _clone.transform.position -= Vector3.right * 0.8f + Vector3.back;
            }
            if (Random.Range(0, 8) <= 1 && (_jump3 == 0 || _jump3 == 3))
            {
                _jump3 = 0;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 2 * 0.8f + Vector3.back * 0;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 2 * 0.8f + Vector3.back * 1;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 2 * 0.8f + Vector3.back * 2;
            }
            else if (Random.Range(0, 16) <= 1)
            {
                _jump3++;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 2 * 0.8f + Vector3.back * 0;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 2 * 0.8f + Vector3.back * 1 + Vector3.down * 0.5f;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 2 * 0.8f + Vector3.back * 2 + Vector3.down * 1f;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 2 * 0.8f + Vector3.back * 3 + Vector3.down * 1f;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 2 * 0.8f + Vector3.back * 4 + Vector3.down * 0.5f;
                _clone = Instantiate(_prefabs);
                _clone.transform.position -= Vector3.right * 2 * 0.8f + Vector3.back * 5;
            }
            else if (Random.Range(0, 8) <= 1)
            {
                _clone = Instantiate(_prefab);
                _clone.transform.position -= Vector3.right * 2 * 0.8f + Vector3.back;
            }
        }
    }
}
//x:-0.8,0,0.8
//z:-15~12