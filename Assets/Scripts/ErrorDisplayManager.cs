using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ErrorDisplayManager : MonoBehaviour
{
    public GameObject errorPanel;
    public TextMeshProUGUI errorMessage;

    public void CloseDialogue()
    {
        errorPanel.SetActive(false);
    }
}
