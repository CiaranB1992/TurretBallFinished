using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public void QuitGame(){
		Debug.Log ("Game is exiting...");
		Application.Quit ();
	}

	public void Medium(){
		Debug.Log ("Medium Difficulty");
		Application.LoadLevel ("BallGame");
	}

	public void Hard(){
		Debug.Log ("Hard Difficulty");
		Application.LoadLevel ("HardGame");
	}

	public void Easy(){
		Debug.Log ("Easy Difficulty");
		Application.LoadLevel ("EasyGame");
	}
}
