using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class audioctrl : MonoBehaviour {

	AudioSource audio;
	public float volume;
	public Slider volSlider;
	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
		volume = PlayerPrefs.GetFloat ("volume");
		audio.volume = volume;
		volSlider.value = volume;
	}


	public void SetVolume(float value)
	{
		audio.volume = value;
		PlayerPrefs.SetFloat("volume", value);
		PlayerPrefs.Save();
	}
}
