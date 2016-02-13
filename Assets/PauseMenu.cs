using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	public GameObject PauseUI;
	public GameObject GameUI;

	private bool paused = false;

	void Start() {

		PauseUI.SetActive (false);
		GameUI.SetActive (true);

	
	}

	void Update() {

		if (paused) {

			GameUI.SetActive(false);
			PauseUI.SetActive(true);
			Time.timeScale = 0;

		}

		if (!paused) {

			GameUI.SetActive(true);
			PauseUI.SetActive(false);
			Time.timeScale = 1;

		}


	}

	public void Resume() {
	
		paused = false;


	}

	public void Restart() {

		Application.LoadLevel(Application.loadedLevel);

	}

	public void MainMenu() {

		Application.LoadLevel (0);

	}

	public void Quit() {

		Application.Quit();

	}

	public void Pause() {
		
		paused = true;
		
	}

	
}
