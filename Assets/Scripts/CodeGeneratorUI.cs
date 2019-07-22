using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    private Text codeText;
    
    private void Start()
    {
        codeText = GetComponent<Text>();
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
            ChangeCode();
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

    public void FamilyCodeReset()
    {
        bristleCodeTemp = "1";
        handleColorATemp = "1";
        handleColorBTemp = "2";
        handleColorCTemp = "3";
        handleColorDTemp = "4";

        ChangeCode();
    }
}
