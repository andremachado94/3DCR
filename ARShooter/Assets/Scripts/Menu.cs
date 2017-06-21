using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public GameObject mainMenuHolder;

	public Slider[] volumeSliders;
	public Toggle[] resolutionToggles;
	public int[] screenWidths;

	void Start() {
		
	}


	public void Play() {
		SceneManager.LoadScene ("MainScene");
	}

	public void Quit() {
		Application.Quit ();
	}

	public void WatchSeries() {
		//Application.OpenURL ("https://youtu.be/SviIeTt2_Lc?list=PLFt_AvWsXl0ctd4dgE1F8g3uec4zKNRV0");
	}
	public void MainMenu() {
		mainMenuHolder.SetActive (true);
		//optionsMenuHolder.SetActive (false);
	}

}
