using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;

public class LoginManager : MonoBehaviour {
	public string userName;
	public string passWord;
	//instanciate new script and put on second screen.
	public Text totalGold;
	public Button loginButton;

	void Start (){
		loginButton  = GameObject.Find ("LoginButton").GetComponent<Button>();
	}
	void Update (){
		loginButton.onClick.AddListener(() => {LoginFunction();});
	}
	// click login 
	//get username - need to find getter function, and then you do username.text
	//find method: 
	public void LoginFunction(){
		//First you need to find the game object
		//GameObject userNameInput = GameObject.Find("UserName");
		//userName = userNameInput.GetComponent<InputField>().text;
		//better way to write it
		userName = GameObject.Find ("UserName").GetComponent<InputField>().text;
		passWord = GameObject.Find ("Password").GetComponent<InputField>().text;
		//check user and password
		if (userName == "Admin" && passWord == "password" || userName == "Admin1" && passWord == "password"){
			LevelManager.LoadLevel("MainMenu");
		}else{
		};
	}
}
