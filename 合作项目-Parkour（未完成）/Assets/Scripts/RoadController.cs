using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadController : MonoBehaviour {
    public GameObject _prefabs;
    public float _speed=1f;
    private static float _type;
    private enum RoadType{ Null,UpPlat, Plat, DownPlat };
    private enum ObjectType { Null,Plat,Up,Magnet,SpeedUp,SpeedDown};
    private static RoadType _roadType=RoadType.Plat;
    private static ObjectType[] _objectType = { ObjectType.Null, ObjectType.Null , ObjectType.Null };
    private static int[] _i = { 0,0,0};
    private static int _nullI;
    private static int _roadHeight=0;
    private GameObject[] _upGolds;
    private GameObject _road;
    private int temp;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //路向前移动
        transform.Translate(Vector3.back * _speed * Time.deltaTime);
        if (_nullI == 3)
        {
            _nullI = 0;
            _roadType = RoadType.Plat;
        }
        else if (_objectType[0] == ObjectType.Null && _objectType[1] == ObjectType.Null && _objectType[2] == ObjectType.Null)
        {
            if ((temp = Random.Range(0,20)) <1)
                _roadType = RoadType.Null;
            else if (temp <)
                _roadType = RoadType.Plat;
            else if (temp <)
            {
                _roadType = RoadType.UpPlat;
                _roadHeight += Random.Range(1,4);
            }
            else if (temp <)
            {
                _roadType = RoadType.DownPlat;
                _roadHeight -= Random.Range(1, 4);
            }
        }
        if (_roadType != RoadType.Null)
        {
            if (_roadType != RoadType.Plat)
                transform.position = Vector3.up * _roadHeight;
            //路产生物体
            for (int j = 0; j < 3; j++)
            {
                if (_objectType[j] == ObjectType.Null)
                {
                    if ((temp = Random.Range(0, 20)) <)
                        _objectType[j] = ObjectType.Null;
                    else if (temp <)
                        _objectType[j] = ObjectType.Plat;
                    else if (temp <)
                        _objectType[j] = ObjectType.Up;
                    else if (temp <)
                        _objectType[j] = ObjectType.Magnet;
                    else if (temp <)
                        _objectType[j] = ObjectType.SpeedUp;
                    else if (temp <)
                        _objectType[j] = ObjectType.SpeedDown ;
                }
                else if (_objectType[j] == ObjectType.Plat)
                {
                    transform.Find("LeftGold").gameObject.SetActive(true);
                    if (++_i[j] == 3)
                    {
                        _i[j] = 0;
                        _objectType[j] = ObjectType.Null;
                    }
                }
                else if (_objectType[j] == ObjectType.Up)
                {
                    if(_i[j]==0)
                        transform.Find("UpGold1").gameObject.SetActive(true);
                    else if(_i[j]==1)
                        transform.Find("UpGold2").gameObject.SetActive(true);
                    else if (_i[j] == 2)
                        transform.Find("UpGold3").gameObject.SetActive(true);
                    else if (_i[j] == 3)
                        transform.Find("UpGold4").gameObject.SetActive(true);
                    else if (_i[j] == 4)
                        transform.Find("UpGold5").gameObject.SetActive(true);
                    else if (_i[j] == 5)
                    {
                        transform.Find("UpGold6").gameObject.SetActive(true);
                        _i[j] = 0;
                        _objectType[j] = ObjectType.Null;
                    }
                }
                else if (_objectType[j] == ObjectType.Magnet)
                    transform.Find("Magnet").gameObject.SetActive(true);
                else if (_objectType[j] == ObjectType.SpeedUp)
                    transform.Find("SpeedUp").gameObject.SetActive(true);
                else if (_objectType[j] == ObjectType.SpeedDown)
                    transform.Find("SpeedDown").gameObject.SetActive(true);
            }
        }
        else
        {
            this.gameObject.SetActive(false);
            _nullI++;
        }
    }
}
