using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public  class Building : MonoBehaviour
{
	// Start is called before the first frame update
	[SerializeField] private string buildingName;
	[SerializeField]private int currentOccupancy;
	[SerializeField]private int maxOccupancy; 
	[SerializeField] private bool canEnter;
	public string buildingStatusText = "";
	public string BuildingName{get{return buildingName;} set{buildingName = value;}}
	public int CurrentOccupancy{get{return currentOccupancy;} set{currentOccupancy = value;}}
	public int MaxOccupancy {get{return maxOccupancy;} set{maxOccupancy = value;}}
	public bool CanEnter { get { return canEnter; } set { canEnter = value; } }
	public int SceneIndex{get{return sceneIndex;}set{sceneIndex = value;}}
	[SerializeField] private int sceneIndex;

	private void Start(){
		canEnter = false;
	}
	public void Update()
	{
		checkBuildingStatus();
	}
	public void checkBuildingStatus()
	{
		 if (CanEnter)
		{
			buildingStatusText = "Open";
		}
		else
		{
			buildingStatusText = "Closed";
		}
	}


	
	
	
}
