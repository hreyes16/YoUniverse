using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharCreationMenu : MenuManager
{	
	GLOBAL_ACTOR_LIST gLOBAL_ACTOR_LIST;

	public GameObject MAIN_MENU_PANEL;
	public GameObject CHARACTER_CREATION_MENU;
	public GameObject GAME_TITLE;
		
	private bool isCCMenuOpen, isMMOpen;
	
	[Header("Character Creation Variables")]
	private string PLAYER_NAME = "";
	private int PLAYER_AGE;
	
	private void Start()
	{
		gLOBAL_ACTOR_LIST = GetComponent<GLOBAL_ACTOR_LIST>();

		MAIN_MENU_PANEL.SetActive(true);
		CHARACTER_CREATION_MENU.SetActive(false);
		isMMOpen = true;
		isCCMenuOpen = false;
	}

	public void toggleCreationMenu()
	{
		//clicking on new game will hide title and hide main menu
		MAIN_MENU_PANEL.SetActive(false);
		GAME_TITLE.SetActive(false);
		CHARACTER_CREATION_MENU.SetActive(true);
		
	} 
	
	
	private void characterCreationControls()
	{
		//character creation instnatites an acctor and adds it to the global list of actor but properties cannot be changed.
		
	}
	
}
