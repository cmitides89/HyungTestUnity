using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;

public class LoginManager : MonoBehaviour {
	public static string userName;
	public string passWord;
	//instanciate new script and put on second screen.
	public static Text totalGold;
	public Image loginButton;
	public string goldStrg;
	public Image RepairButton;
	public Image SellButton;
	//public LevelManager levelManager;

	void Start ()
	{
		if (Application.loadedLevelName == "Login" )
		{
			loginButton  = GameObject.Find ("LoginButton").GetComponent<Image>();
		}else if (Application.loadedLevelName == "MainMenu")
		{
			totalGold = GameObject.Find("TotalGold").GetComponent<Text>();
			MoneyManager.convertString(totalGold);
		}else if (Application.loadedLevelName == "Shop")
		{
			RepairFunction();
			SellFunction();
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
		//check user and password
		if (userName == "Admin" && passWord == "password"
		 	|| userName == "Admin1" && passWord == "password1")
		{
			Application.LoadLevel("MainMenu");
		}else{
			Debug.Log("Else Statement");
			Debug.Log(userName + passWord);
		};
	}
	public void RepairFunction()
	{
		RepairButton = GameObject.Find("RepairButton").GetComponent<Image>();
		
		
	}
	public void SellFunction()
	{
		SellButton = GameObject.Find("SellButton").GetComponent<Image>();
	}
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