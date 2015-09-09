using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {
	public string goldStrg;
	public string str1;
	public string str2;
	public int int1;
	public int int2;
	public static Text totalGold;
	public Image ShopButton;
	// Use this for initialization
	void Start () {
		totalGold = GameObject.Find("TotalGold").GetComponent<Text>();
		ShopButton = GameObject.Find("ShopButton").GetComponent<Image>();
		DisplayUserInfo();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void DisplayUserInfo()
	{
		LevelManager.initalize( ref str1, 
								ref str2, 
								ref int1, 
								ref int2);
		Debug.Log(str1);
		string UserName = str1;
		string UserName2 = str2;
		if(UserName != str2)
		{
			//change int1 and int2 into a string inside the lvlmanger class
			goldStrg = goldToStringFunction(int1);
			totalGold.text = goldStrg;
		}else if(UserName2 != str1){
			goldStrg = goldToStringFunction(int2);
			totalGold.text = goldStrg;
		};
	}
	public void ShopFunction()
	{
		Application.LoadLevel("Shop");
	}
	//Convert gold from number to Text
	public string goldToStringFunction(int goldInt)
	{
		string goldString;
		goldString = goldInt.ToString();
		return goldString;
	}

}
