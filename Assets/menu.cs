using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
	public bool isOpened = false;
	
    public void ShowHideMenu()
	{
		isOpened = !isOpened;
		GetComponent<Canvas>().enabled = isOpened; //Включение или отключение Canvas. Ещё тут можно использовать метод SetActive()
	}

    // Update is called once per frame
    void Update() 
	{
		if(Input.GetKey(KeyCode.Escape)) 
		{
			ShowHideMenu();
		}
	}

	public void ChooseLevel()
	{
		Application.LoadLevel("LVLS");
	}

	public void Quit()
	{
		Application.Quit();
	}
}
