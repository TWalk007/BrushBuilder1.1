using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class CodeGeneratorUI : MonoBehaviour
{
    public bool codeHasChanged = true;

    [HideInInspector]
    public string[] familyCode = new string[] { "1","2","3","4","5","6","7","8","9" };
    [HideInInspector]
    public string[] bristleCode = new string[] { "1", "2", "3" };
    [HideInInspector]
    public string[] handleColor = new string[] { "1", "2", "3", "4", "5", "6", "7", "8" };   

    public string familyCodeTemp;
    public string bristleCodeTemp;
    public string handleColorATemp;
    public string handleColorBTemp;
    public string handleColorCTemp;
    public string handleColorDTemp;

    private TextMeshProUGUI codeText;
    private TMP_InputField tmpInputField;

    private char[] TextTemp = new char[6];

    private ErrorDisplayManager errorDisplayManager;

    private void Start()
    {
        tmpInputField = GetComponent<TMP_InputField>();
        codeText = GetComponent<TextMeshProUGUI>();
        errorDisplayManager = FindObjectOfType<ErrorDisplayManager>();
        familyCodeTemp = "1";
        bristleCodeTemp = "1";
        handleColorATemp = "1";
        handleColorBTemp = "2";
        handleColorCTemp = "3";
        handleColorDTemp = "4";
    }

    private void Update()
    {
        if (codeHasChanged)
        {
            tmpInputField.onEndEdit.AddListener(delegate { ValueChangeCheck(); });
            ChangeCode();

            //Debug.Log("codeText variable is " + codeText.text);
        }
    }

    private void ChangeCode()
    {
        codeText.text =   familyCodeTemp
                        + bristleCodeTemp
                        + handleColorATemp
                        + handleColorBTemp
                        + handleColorCTemp
                        + handleColorDTemp;

        codeHasChanged = false;
    }

    public void ValueChangeCheck()
    {
        //Debug.Log("Value has changed");
        codeHasChanged = true;

        //Add text to list.
        CheckInputText();
        //Throw any errors to let the user know something is incorrect.

    }

    public void FamilyCodeReset()
    {
        bristleCodeTemp = "1";
        handleColorATemp = "1";
        handleColorBTemp = "2";
        handleColorCTemp = "3";
        handleColorDTemp = "4";



        ChangeCode();
    }



    private void CheckInputText()
    {
        TextTemp = tmpInputField.text.ToCharArray();

        /*Check to make sure the array was correctly created.
        for (int i = 0; i < TextTemp.Length; i++)
        {
            print(TextTemp[i]);
        }
        */

        //check for errors.
        if (TextTemp.Length < 6)
        {
            Debug.LogError("You must enter 6 numbers.  Please try again.");
            errorDisplayManager.errorPanel.SetActive(true);
            errorDisplayManager.errorMessage.text = "You must enter 6 numbers.  Please try again.";
        }


        if ((int)Char.GetNumericValue(TextTemp[0]) >= 10)
        {
            Debug.LogError("Incorrect family value. Please choose a number between 1 and 9.");
            errorDisplayManager.errorPanel.SetActive(true);
            errorDisplayManager.errorMessage.text = "Incorrect family value!Please choose a number between 1 and 9.";
        }
        else if ((int)Char.GetNumericValue(TextTemp[1]) >= 4)
        {
            Debug.LogError("Incorrect bristle code number (the second digit). Please choose a number between 1 and 3.");
            errorDisplayManager.errorPanel.SetActive(true);
            errorDisplayManager.errorMessage.text = "Incorrect bristle code number (the second digit)! Please choose a number between 1 and 3.";
        }
        else if ((int)Char.GetNumericValue(TextTemp[2]) >= 9)
        {
            Debug.LogError("Incorrect brush color code number (the 3rd digit). Please choose a number between 1 and 8.");
            errorDisplayManager.errorPanel.SetActive(true);
            errorDisplayManager.errorMessage.text = "Incorrect brush color code number!  Digits 3-6 need to have a number between 1 and 8.";
        }
        else if ((int)Char.GetNumericValue(TextTemp[3]) >= 9)
        {
            Debug.LogError("Incorrect brush color code number (the 4th digit). Please choose a number between 1 and 8.");
            errorDisplayManager.errorPanel.SetActive(true);
            errorDisplayManager.errorMessage.text = "Incorrect brush color code number!  Digits 3-6 need to have a number between 1 and 8.";
        }
        else if ((int)Char.GetNumericValue(TextTemp[4]) >= 9)
        {
            Debug.LogError("Incorrect brush color code number (the 5th digit). Please choose a number between 1 and 8.");
            errorDisplayManager.errorPanel.SetActive(true);
            errorDisplayManager.errorMessage.text = "Incorrect brush color code number!  Digits 3-6 need to have a number between 1 and 8.";
        }
        else if ((int)Char.GetNumericValue(TextTemp[5]) >= 9)
        {
            Debug.LogError("Incorrect brush color code number (the 6th digit). Please choose a number between 1 and 8.");
            errorDisplayManager.errorPanel.SetActive(true);
            errorDisplayManager.errorMessage.text = "Incorrect brush color code number!  Digits 3-6 need to have a number between 1 and 8.";
        }
    }
}
