using UnityEngine;
using System.Collections;

public static class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
		Debug.Log ("New Level Load: " + name);
		Application.LoadLevel (name);
	}
	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}
}
