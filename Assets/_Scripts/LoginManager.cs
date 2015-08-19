using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LoginManager : MonoBehaviour {
	// click login 
	//get username - need to find getter function, and then you do username.text
	//find method: 
	public string userName;
	public int gold;
	private void LoginFunction(){
		//First you need to find the game object
		//GameObject userNameInput = GameObject.Find("UserName");
		//userName = userNameInput.GetComponent<InputField>().text;
		//better way to write it
		userName = GameObject.Find ("UserName").GetComponent<InputField>().text;
		if (userName == "Admin"){
			gold = 1000;
		}else{
			gold = 500;
		};
	}
}
