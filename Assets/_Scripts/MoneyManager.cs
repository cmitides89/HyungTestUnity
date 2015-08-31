using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;

public class MoneyManager : MonoBehaviour {
	public static Text totalGold = LoginManager.totalGold;
	public static string goldStrg;
	public static string userName;
	public Image RepairButton;
	public Image SellButton;

	// Use this for initialization
	void Start () {
		userName = LoginManager.userName;
	
	}
	
	// Update is called once per frame
	void Update () 
	{
			
	}

	public static string convertString(Text totalGold)
	{
		if(userName == "Admin")
		{
			goldStrg = "1000";
			totalGold.text = goldStrg.ToString();
			Debug.Log(goldStrg);

			//convertToInt(goldStrg);

		}else if( userName == "Admin1"){
			goldStrg = "500";
			totalGold.text = goldStrg.ToString();
			//Debug.Log(goldStrg);
		}
		return goldStrg;
	}

	// public int addOrSubtractGold(int goldNum)
	// {
		 
	// 	//if sell clicked ++ 50

	// 	//if buy clicked - 100
	// }

	// public static int convertToInt(string goldStrg)
	// {
	// 	int goldNum = 0;
	// 	for (int i = 0; i < goldStrg.Length; i++)
	// 	{
	// 		char letter = goldStrg[i];
	// 		goldNum = 10 * goldNum + (letter - 48);
	// 	}
	// 	this.addOrSubtractGold(goldNum);
	// 	return goldNum;
	// }

}
