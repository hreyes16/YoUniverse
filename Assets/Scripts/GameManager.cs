using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
	[SerializeField] private Button[] buttons;
	public SceneController sceneController;



	// Update is called once per frame
	void Update()
	{
		if(!sceneController){
			Debug.Log("Scene Cntroller does not exist");
		}
	}
	
	
	public void  show_NewGame()
	{
		Debug.Log("Displaying new game");
	}
	
	
	public void goto_Game()
	{
		Debug.Log("Going to main game");
		sceneController.LoadScene(1);

	}
	
	public void show_OptiosMenu()
	{
		Debug.Log("Clicked Optiosn");

	}

	
	
	
}
