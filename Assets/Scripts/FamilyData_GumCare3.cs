using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FamilyData_GumCare3 : MonoBehaviour
{
    [Header("BRUSH DISPLAY PANELS")]
    public GameObject[] brushDisplayPanels = new GameObject[4];

    [Header("BRUSH HEAD DISPLAY PANELS")]
    public GameObject[] brushHeadDisplayPanels = new GameObject[4];

    [Header("HANDLE COLORS")]
    public Sprite[] handleColors = new Sprite[8];

    [Header("HANDLE HEAD COLORS")]
    [Header("_____________________________________________________________")]
    public Sprite[] handleHeadColors = new Sprite[3];

    [Space(10)]
    [Header("BRISTLE HEAD IMAGE")]
    [Header("_____________________________________________________________")]
    public GameObject BristleHead;

    [Header("LARGE BRISTLE HEAD SPRITES")]
    public Sprite[] largeBristleHeadSprites = new Sprite[3];
}
