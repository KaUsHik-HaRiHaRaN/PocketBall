using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class jetwarp : MonoBehaviour {

	public timer timeCounter;
	public Text HiScore;
	public string hiScoreKey;
	public string lvlUnlockKey;

	void Start () {
		timeCounter = GameObject.FindGameObjectWithTag ("Player").GetComponent<timer> ();
		HiScore.text = PlayerPrefs.GetFloat (hiScoreKey).ToString ("F2");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider obj) {  
		var tag = obj.gameObject.tag;
		
		if (tag == "Player") {
			Application.LoadLevel(0);
			var score = float.Parse(HiScore.text);
			PlayerPrefs.SetInt(lvlUnlockKey, 1);
			if (timeCounter.curTime < score) { 
				PlayerPrefs.SetFloat(hiScoreKey,timeCounter.curTime);
			}
		}
	}
}