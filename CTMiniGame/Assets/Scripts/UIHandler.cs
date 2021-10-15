using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

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

    private float currentTime = 0.0f;

    private bool isInGame = false;
    
    private void Start()
    {
        string input = inputName.GetComponent<TMP_InputField>().text;
        
        inputName.onEndEdit.AddListener(SubmitName);
    }

    private void Update()
    {
        if (isInGame)
        {
            // Start timer
            currentTime += Time.deltaTime;
            
            // Update UI Text
            timer.SetText(ConvertFloatToTime(currentTime));
        }
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
        isInGame = true;

        // Start game state
    }

    string ConvertFloatToTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);  
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    
    public void SetHudVisibility(bool isVisible)
    {
        hudDisplay.SetActive(isVisible);
        
        // variable for set text in HUD
    }
    
    // Display name submitted and update score
    // override for score

    public void UpdateCurrentNameAndScore(float score)
    {
        score = Random.Range(30.0f, 300.0f);
        
        currentPlayerDetails.SetText(currentPlayerName + " : " + ConvertFloatToTime(score));
    }
}

// Game Mode
// Timer - Count up/down on Start()
