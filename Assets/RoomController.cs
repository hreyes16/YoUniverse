using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomController : MonoBehaviour
{
	// Start is called before the first frame update
	public GameObject selectedActor = null;
	public LayerMask neighborLayerMask;
	
	
	void Update()
	{
		SELECT_NEIGHBOR();
	}	
	public void SELECT_NEIGHBOR()
	{
		if(Input.GetMouseButtonDown(0)){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			
			if (Physics.Raycast(ray, out hit,  Mathf.Infinity,neighborLayerMask))
			{
				var neighborActor = hit.collider.gameObject.GetComponent<NEIGHBOR_ACTOR>();
				selectedActor = neighborActor.gameObject;
				if(neighborActor != null)
				{
					//move agent to SELECTED_STATE_WAYPOINT
					Debug.Log("Selected: " + selectedActor.tag);
				}
				}
				
			}
	}
}
