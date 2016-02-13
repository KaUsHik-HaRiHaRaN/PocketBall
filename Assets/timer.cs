using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timer : MonoBehaviour {

	public Text timeDisplay;
	public float curTime = 0f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		curTime += Time.deltaTime;
		timeDisplay.text = "Time: " + curTime.ToString("F2");
	}

}
