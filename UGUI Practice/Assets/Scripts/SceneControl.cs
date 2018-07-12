using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControl : MonoBehaviour {
    public Animator _startButton;
    public Animator _fourMenPlane;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Open()
    {
        _startButton.SetBool("Is True",true);
        _fourMenPlane.enabled = true;
        _fourMenPlane.SetBool("isTrue",false);
    }
    public void Close()
    {
        _startButton.SetBool("Is True",false);
        _fourMenPlane.SetBool("isTrue",true);
    }
}
