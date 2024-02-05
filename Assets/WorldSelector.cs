using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WorldSelector : MonoBehaviour
{
	public SceneController sceneController;
	public LayerMask buildingLayer;
	public Text buildingStatus;
	public Text buildingOccupants;
	public Text buildingName;
	public Button enterSceneButton;

	public GameObject SELECTED_BUILDING;
	
	
	public void Update(){
		SELECT_BUILDING();
	}
	
	public void SELECT_BUILDING()
	{
		if(Input.GetMouseButtonDown(0)){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			
			if (Physics.Raycast(ray, out hit,  Mathf.Infinity,buildingLayer))
			{
				var building = hit.collider.gameObject.GetComponent<Building>();
				Debug.Log(building.BuildingName);
				buildingName.text = building.BuildingName.ToString();
				buildingStatus.text = building.buildingStatusText;
				SELECTED_BUILDING = building.gameObject;
				}
			}
		}
		
	public void ENTER_PLAYER_ROOM()
	{
		Building selected = SELECTED_BUILDING.GetComponent<Building>();
		sceneController.LoadScene(selected.SceneIndex);
		Debug.Log("Room Index: " + selected.SceneIndex);
	}
		
	
	}
	
