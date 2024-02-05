using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ACTOR_MANAGER : MonoBehaviour
{
	GLOBAL_ACTOR_LIST gLOBAL_ACTOR_LIST;
	public List<ACTOR_APARTMENT_OBJ> actorApartmentObjects;
	public GameObject ACTOR_OBJ;
	public GameObject actorUIList;
	private void Start()
	{
		gLOBAL_ACTOR_LIST = GetComponent<GLOBAL_ACTOR_LIST>();
	}
	private void Update()
	{
		//gLOBAL_ACTOR_LIST.PRINT_ALL_NPC_FROM_GLOBAL_LIST();
		INSERT_ACTOR_INTO_HOME();
	}
	
	private protected void ADD_PLAYER()
	{
		
	}
	private void INSERT_ACTOR_INTO_HOME()
	{
		actorApartmentObjects.Clear();
		
		if(gLOBAL_ACTOR_LIST.actorList.Count > 0)
		{
			//Debug.Log("List contains actors");
		
			 foreach (Transform child in actorUIList.transform)
			{
				Destroy(child.gameObject);
			}
			
			foreach (NEIGHBOR_ACTOR actor in gLOBAL_ACTOR_LIST.actorList)
			{
				GameObject newActorObj = Instantiate(ACTOR_OBJ, actorUIList.transform);
				ACTOR_APARTMENT_OBJ aptObject = newActorObj.GetComponent<ACTOR_APARTMENT_OBJ>();
			
				aptObject.npcName.text = actor.NPC_NAME;
			}	
		}
	}
}
