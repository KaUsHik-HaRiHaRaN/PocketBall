using UnityEngine;
using System.Collections;

public class colorChange : MonoBehaviour {

	public Renderer Player;
	public Material mat;
	public string color;
	// Use this for initialization
	void Start () {
		Player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider col)
	{
		var tag = col.gameObject.tag;

		if (tag == "Player") {
			Player.sharedMaterial = mat;
			PlayerPrefs.SetString("color", color);
			PlayerPrefs.Save();
		}
	}
}
