using UnityEngine;
using System.Collections;

public class LevelManager 
{

	public static void LoadLevel(string name)
	{
		Debug.Log ("New Level Load: " + name);
		Application.LoadLevel (name);
	}
	public static void QuitRequest()
	{
		Debug.Log ("Quit requested");
		Application.Quit ();
	}
}
