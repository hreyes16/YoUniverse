using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class NEIGHBOR_ACTOR : MonoBehaviour
{
	public float boredom, hunger, happiness;
	private bool isFriends = false;
	
	private Image npcImageIcon;
	private string npcName;
	private int npcAge;
	
	
	public int NPC_AGE
	{
		get{return npcAge;}
		set{npcAge = value;}
	}
	
	public string NPC_NAME
	{
		get{return npcName;}
		set{npcName = value;}
	}
	
	public Image NPC_IMAGE
	{
		get{return npcImageIcon;}
		set{npcImageIcon = value;}
	}
}
