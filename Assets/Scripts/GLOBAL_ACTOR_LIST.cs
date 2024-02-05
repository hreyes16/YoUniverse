using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GLOBAL_ACTOR_LIST : MonoBehaviour
{
	GLOBAL_ACTOR_LIST instance;
	[SerializeField] private List<NEIGHBOR_ACTOR> GLOBAL_NPC_LIST = new List<NEIGHBOR_ACTOR>();
	//here we control the npcs when they arrive tot he island and populate the building then we will access this script from others to do certain things
	
	public List<NEIGHBOR_ACTOR> actorList{get{return GLOBAL_NPC_LIST;}set{GLOBAL_NPC_LIST = value;}}
	
	void Awake()
	{
		instance = this;
	}
	void Start()
	{
		NEIGHBOR_ACTOR bob = new NEIGHBOR_ACTOR();
		bob.NPC_NAME = "BOB";
		bob.NPC_AGE = 20;

		NEIGHBOR_ACTOR jessica = new NEIGHBOR_ACTOR();
		jessica.NPC_NAME = "JESSICA";
		jessica.NPC_AGE = 24;
		
		GLOBAL_NPC_LIST.Add(bob);
		GLOBAL_NPC_LIST.Add(jessica);

		
	}
	
	void Update()
	{
		//PRINT_ALL_NPC_FROM_GLOBAL_LIST();
	}
	
	
	public void PRINT_ALL_NPC_FROM_GLOBAL_LIST()
	{
		foreach (NEIGHBOR_ACTOR npcChar in GLOBAL_NPC_LIST)
		{
			Debug.Log(npcChar.NPC_NAME);
		}
	}
	

	
}
