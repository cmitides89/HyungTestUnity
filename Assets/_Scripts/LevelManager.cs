using UnityEngine;
using System.Collections;

public class LevelManager 
{
	public static LevelManager lvlManager = new LevelManager();
	//void Awake()
	//{
	//}
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
	public static void initalize( ref string Name,  
									ref string Name2,  
									ref int admin_Gold,  
									ref int admin_Gold1)
	{
		Name = "Admin";
		Name2 = "Admin1";
		admin_Gold = 1000;
		admin_Gold1 = 500;
	}
}
