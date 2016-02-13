using UnityEngine;
using System.Collections;

public class unlock : MonoBehaviour {

	public string level;

	// Use this for initialization
	void Start () {

		if (PlayerPrefs.GetInt (level) == 1) {

			Destroy(gameObject);

		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
