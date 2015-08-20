using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class LoginManager : MonoBehaviour {
	public string userName;
	public Text totalGold;
	public Button loginButton;

	void Start (){

	}
	void Update (){
		LoginFunction();
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
		if (userName == "Admin"){
			totalGold.text = "1000";
		}else{
			totalGold.text = "500";
		};
	}
}
