using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveCharacter : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Character newCharacter = new Character();
        newCharacter.charName = null;


        string json = JsonUtility.ToJson(newCharacter);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
