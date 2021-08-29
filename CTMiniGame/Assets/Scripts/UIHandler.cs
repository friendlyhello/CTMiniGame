using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    [SerializeField] private GameObject titleScreen;
    [SerializeField] private TMP_InputField inputName;
    [SerializeField] private TMP_Text displayInputName;
    
    private void Start()
    {
        string text = inputName.GetComponent<TMP_InputField>().text;
        
        inputName.onEndEdit.AddListener(SubmitName);
    }

   
    private void SubmitName(string input)
    {
        Debug.Log(input);
        
        // displayInputName.text = input;
        
        // This is the same as above, but this is the recommended way:
        displayInputName.SetText(input);
    }
    
    public void StartGame()
    {
        titleScreen.SetActive(false);
        
        // Start game state
    }
}
    
    // What am I doing?
    //  1. InputField registers name and saves it to memory
    //  2. Play button hides title screen
    //  3. GameOver state triggers the Game Over menu and displays Back
    //     to Title button and Quit Button
    //  4. Pause Menu button shows Back to Title button and Quit buttons
