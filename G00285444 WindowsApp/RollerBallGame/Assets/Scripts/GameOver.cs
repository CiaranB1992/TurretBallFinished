using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	public void QuitGameGameOver(){
		Debug.Log ("Game is exiting...");
		Application.Quit ();
	}

	public void MainMenu(){
		Debug.Log ("MainMenu is loading...");
		Application.LoadLevel ("MainMenu");
	}
}
