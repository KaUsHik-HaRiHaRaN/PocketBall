using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class levelwarp : MonoBehaviour {

	public int level;
	public bool isUnlocked = false;
	public string unlockKey;

	void Start () {
		//PlayerPrefs.DeleteAll ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider obj) {  
		var tag = obj.gameObject.tag;

		if (PlayerPrefs.GetInt (unlockKey) == 1) {

			isUnlocked = true;

		}

		if (tag == "Player" && isUnlocked) {
			Application.LoadLevel(level);
		}
	}
}
