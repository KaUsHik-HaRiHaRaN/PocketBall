using UnityEngine;
using System.Collections;

public class spikeTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider obj) {  
		var tag = obj.gameObject.tag;
		
		// If it collided with a bullet
		if (tag == "Player") {
			Application.LoadLevel(Application.loadedLevel);
		}
	}

	
}
