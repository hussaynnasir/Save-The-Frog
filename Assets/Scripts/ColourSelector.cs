using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourSelector : MonoBehaviour {

	SpriteRenderer colourSelector;

	[SerializeField]
	private Color colourToTurnTo;

	public int CharacterID;

	// Use this for initialization
	void Start () {
		
		CharacterID = PlayerPrefsManager.GetDefaultCharacter ();
		colourSelector = GetComponent<SpriteRenderer> ();
		colourSelector.material.color = colourToTurnTo;
		CheckSkinColour ();
	}
	
	// Update is called once per frame
	void Update () {

		CharacterID = PlayerPrefsManager.GetDefaultCharacter ();
		colourSelector.material.color = colourToTurnTo;
		CheckSkinColour ();
	}

	void CheckSkinColour()
	{
		if (CharacterID == 1) 
		{
			colourToTurnTo = Color.white;
		}
		if (CharacterID == 2) 
		{
			colourToTurnTo = Color.blue;
		}
		if (CharacterID == 3) 
		{
			colourToTurnTo = Color.red;
		}
	}
		
}
