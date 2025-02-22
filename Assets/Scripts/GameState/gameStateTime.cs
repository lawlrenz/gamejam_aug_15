﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameStateTime : MonoBehaviour {
	Text currTime;
	
	// Use this for initialization
	void Start () {
		PlayerPrefs.SetFloat("LevelStartTime", Time.realtimeSinceStartup);
		currTime = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		currTime.text = (Time.realtimeSinceStartup - PlayerPrefs.GetFloat("LevelStartTime")).ToString("#.00");
		PlayerPrefs.SetFloat ("CurrTime",(Time.realtimeSinceStartup - PlayerPrefs.GetFloat("LevelStartTime")));
	}
}
