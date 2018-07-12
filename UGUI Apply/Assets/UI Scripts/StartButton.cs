using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartButton : MonoBehaviour {
    public Animator _startButton;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Open() {
        _startButton.SetBool("isTrue",true);
        SceneManager.LoadScene("Running Ball");
    }
}
