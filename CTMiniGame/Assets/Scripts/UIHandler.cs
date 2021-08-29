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
    // [SerializeField] private TMP_Text displayInputName;

    private void Start()
    {
        // How does var work? What should I have used instead of var?
        TMP_InputField getInput = gameObject.GetComponent<TMP_InputField>();
        
        
        getInput.onEndEdit.AddListener(SubmitName);
    }

    private void SubmitName(string input)
    {
        Debug.Log(input);
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
    //  3. GameOver state and Pause Menu button shows Back to Title button and Quit Button
