using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    [SerializeField]
    private GameObject titleScreen;

    [SerializeField] 
    private GameObject hudDisplay;
    
    [SerializeField] 
    private TMP_InputField inputName;
    
    [SerializeField]
    private TMP_Text displayInputName;

    [SerializeField] 
    private TMP_Text currentPlayerDetails;
    
    [SerializeField] 
    private TMP_Text timer;

    private string currentPlayerName = "";
    
    private void Start()
    {
        string input = inputName.GetComponent<TMP_InputField>().text;
        
        inputName.onEndEdit.AddListener(SubmitName);
    }

   
    private void SubmitName(string input)
    {
        Debug.Log(input);
        
        // displayInputName.text = input;
        
        // This is the same as above, but this is the recommended way:
        displayInputName.SetText(input);
        currentPlayerName = input;
        
        UpdateCurrentNameAndScore(0);
    }
    
    public void HideTitleMenu()
    {
        titleScreen.SetActive(false);

        // Start game state
    }

    public void SetHudVisibility(bool isVisible)
    {
        hudDisplay.SetActive(isVisible);
        
        // variable for set text in HUD
    }
    
    // Display name submitted and update score
    // override for score

    public void UpdateCurrentNameAndScore(int score)
    {
        currentPlayerDetails.SetText(currentPlayerName + " : " + score.ToString());
    }
}

// Game Mode
// Timer - Count up/down on Start()
