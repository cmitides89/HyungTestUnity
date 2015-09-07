using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;

public class LoginManager : MonoBehaviour {
	public string userName;
	public string passWord;
	//instanciate new script and put on second screen.
	public Image loginButton;
	public Image RepairButton;
	public Image SellButton;
	public string str1;
	public string str2;
	public int int1;
	public int int2;
	
	//public LevelManager levelManager;

	void Start ()
	{
		if (Application.loadedLevelName == "Login" )
		{
			loginButton  = GameObject.Find ("LoginButton").GetComponent<Image>();
		}else if (Application.loadedLevelName == "MainMenu")
		{
			
			//MoneyManager.convertString(totalGold);
		}else if (Application.loadedLevelName == "Shop")
		{
			//RepairFunction();
			//SellFunction();
		}
		
	}	
	void Update ()
	{
		//loginButton.onClick.AddListener(() => {LoginFunction();});
	}
	// click login 
	//get username - need to find getter function, and then you do username.text
	//find method: 
	public void LoginFunction()
	{
		//First you need to find the game object
		//GameObject userNameInput = GameObject.Find("UserName");
		//userName = userNameInput.GetComponent<InputField>().text;
		//better way to write it
		userName = GameObject.Find ("UserName").GetComponent<InputField>().text;
		passWord = GameObject.Find ("Password").GetComponent<InputField>().text;
		//string UserName = LevelManager.UserName;
		//string UserName2 = LevelManager.UserName2;
		//check user and password
		

		LevelManager.initalize( ref str1, ref str2, ref int1, ref int2);
		Debug.Log(str1);
		string UserName = str1;
		string UserName2 = str2;
		if (userName == UserName && passWord == "password"
		 	|| userName == UserName2 && passWord == "password1")
		{
			Debug.Log("the user name" + UserName);
			Application.LoadLevel("MainMenu");
		}else{
			Debug.Log("Else Statement");
			Debug.Log(userName + passWord);
		};
	}
	//public void RepairFunction()
	//{
	//	RepairButton = GameObject.Find("RepairButton").GetComponent<Image>();
		
		
	//}
	//public void SellFunction()
	//{
	//	SellButton = GameObject.Find("SellButton").GetComponent<Image>();
	//}
	// public void GetUserInfo(string username, string password)
	// {
	// 	username = GameObject.Find ("UserName").GetComponent<InputField>().text;
	// 	password = GameObject.Find ("Password").GetComponent<InputField>().text;
	// }

	// public void LevelChanger(string name)
	// {
	// 	Application.LoadLevel (name);

	// }
}