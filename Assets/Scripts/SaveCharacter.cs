using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SaveCharacter : MonoBehaviour
{

    public TMP_InputField nameInput;

    // Use this for initialization
    void Start()
    {
        Character newCharacter = new Character();
        newCharacter.charName = nameInput.text;


        string json = JsonUtility.ToJson(newCharacter);
    }
}
