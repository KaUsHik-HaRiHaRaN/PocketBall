using UnityEngine;
using System.Collections;

public class loadColor : MonoBehaviour {

	public string color;
	public Material red;
	public Material orange;
	public Material norm;
	public Material green;
	public Material blue;
	public Renderer Player;

	// Use this for initialization
	void Start () {
		color = PlayerPrefs.GetString ("color");
		Player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Renderer> ();

		if (color == "red") {
			Player.sharedMaterial = red;
		} else if (color == "green") {
			Player.sharedMaterial = green;
		} else if (color == "blue") {
			Player.sharedMaterial = blue;
		} else if (color == "orange") {
			Player.sharedMaterial = orange;
		} else {
			Player.sharedMaterial = norm;
		}
	}
	
	// Update is called once per frame
	void Update () {
		 
	}
}
