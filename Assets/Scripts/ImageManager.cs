using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageManager : MonoBehaviour
{    
    public enum Family
    {
        Whitening1,
        Whitening2,
        Whitening3,
        GumCare1,
        GumCare2,
        GumCare3,
        AdvancedCleaning1,
        AdvancedCleaning2,
        AdvancedCleaning3
      };

    [Space(10)]
    public Family family;

    #region Public GameObjects
    public GameObject wht1;
    public GameObject wht2;
    public GameObject wht3;
    public GameObject gc1;
    public GameObject gc2;
    public GameObject gc3;
    public GameObject ac1;
    public GameObject ac2;
    public GameObject ac3;

    [Space(10)]
    [Header("SKELETON SWATCHES")]
    [Header("=============================================================")]
    public GameObject wht1SkeletonSwatchHL;
    public GameObject wht2SkeletonSwatchHL;
    public GameObject wht3SkeletonSwatchHL;
    public GameObject gc1SkeletonSwatchHL;
    public GameObject gc2SkeletonSwatchHL;
    public GameObject gc3SkeletonSwatchHL;
    public GameObject ac1SkeletonSwatchHL;
    public GameObject ac2SkeletonSwatchHL;
    public GameObject ac3SkeletonSwatchHL;


    [Space(10)]
    [Header("FAMILY HIGHLIGHTS")]
    [Header("=============================================================")]
    public Sprite whiteningFamily;
    public Sprite whiteningFamilyHL;
    public Sprite gumCareFamily;
    public Sprite gumCareFamilyHL;
    public Sprite advCleaningFamily;
    public Sprite advCleaningFamilyHL;
    [Space(10)]
    [Header("FAMILY GAMEOBJECTS")]
    [Header("_____________________________________________________________")]
    public GameObject whtFamily;
    public GameObject gcFamily;
    public GameObject acFamily;

    [Space(10)]
    [Header("FAMILY BRISTLE COLORS")]
    [Header("_____________________________________________________________")]
    public GameObject currentBristleSwatchHL;

    #endregion


    private GameObject currentPanel;
    private GameObject currentHL;

    [HideInInspector]
    public bool familyHasChanged = false;


    //TODO Place all of the scripts for each family here.
    private FamilyData_Whitening1 famDataWht1;
    private FamilyData_Whitening2 famDataWht2;
    private FamilyData_Whitening3 famDataWht3;
    private FamilyData_GumCare1 famDataGc1;
    private FamilyData_GumCare2 famDataGc2;
    private FamilyData_GumCare3 famDataGc3;
    private FamilyData_AdvancedCleaning1 famDataAc1;
    private FamilyData_AdvancedCleaning2 famDataAc2;
    private FamilyData_AdvancedCleaning3 famDataAc3;

    // This is a placeholder variable to put the correct family colors to grab into these slots.
    [HideInInspector]
    public GameObject[] brushDisplayPanels;
    [HideInInspector]
    public GameObject[] brushHeadDisplayPanels;
    [HideInInspector]
    public Sprite[] activeHandleColors;
    [HideInInspector]
    public Sprite[] activeBristleColors;
    [HideInInspector]
    public Sprite[] activeLargeBristleHeads;

    public GameObject activeHandle;
    public GameObject activeHandleHead;

    private void Start()
    {
        family = Family.Whitening1;
        currentPanel = wht1;
        currentHL = wht1SkeletonSwatchHL;

        famDataWht1 = this.gameObject.GetComponent<FamilyData_Whitening1>();
        famDataWht2 = this.gameObject.GetComponent<FamilyData_Whitening2>();
        famDataWht3 = this.gameObject.GetComponent<FamilyData_Whitening3>();
        famDataGc1 = this.gameObject.GetComponent<FamilyData_GumCare1>();
        famDataGc2 = this.gameObject.GetComponent<FamilyData_GumCare2>();
        famDataGc3 = this.gameObject.GetComponent<FamilyData_GumCare3>();
        famDataAc1 = this.gameObject.GetComponent<FamilyData_AdvancedCleaning1>();
        famDataAc2 = this.gameObject.GetComponent<FamilyData_AdvancedCleaning2>();
        famDataAc3 = this.gameObject.GetComponent<FamilyData_AdvancedCleaning3>();

        brushDisplayPanels = famDataWht1.brushDisplayPanels;
        brushHeadDisplayPanels = famDataWht1.brushHeadDisplayPanels;
        activeHandleColors = famDataWht1.handleColors;
        activeBristleColors = famDataWht1.handleHeadColors;
        activeLargeBristleHeads = famDataWht1.largeBristleHeadSprites;
    }

    private void Update()
    {
        #region enum Family Switch
        if (family == Family.Whitening1)
        {
            currentPanel.SetActive(false);
            currentPanel = wht1;
            currentPanel.SetActive(true);

            currentHL.SetActive(false);
            currentHL = wht1SkeletonSwatchHL;
            currentHL.SetActive(true);

            SwitchFamilyHighlight();
            if (familyHasChanged)
            {
                FamilyChange();
            }

        }
        else if (family == Family.Whitening2)
        {
            currentPanel.SetActive(false);
            currentPanel = wht2;
            currentPanel.SetActive(true);

            currentHL.SetActive(false);
            currentHL = wht2SkeletonSwatchHL;
            currentHL.SetActive(true);

            SwitchFamilyHighlight();

            if (familyHasChanged)
            {
                FamilyChange();
            }
        }
        else if (family == Family.Whitening3)
        {
            currentPanel.SetActive(false);
            currentPanel = wht3;
            currentPanel.SetActive(true);

            SwitchFamilyHighlight();

            currentHL.SetActive(false);
            currentHL = wht3SkeletonSwatchHL;
            currentHL.SetActive(true);

            if (familyHasChanged)
            {
                FamilyChange();
            }
        }
        else if (family == Family.GumCare1)
        {
            currentPanel.SetActive(false);
            currentPanel = gc1;
            currentPanel.SetActive(true);

            SwitchFamilyHighlight();

            currentHL.SetActive(false);
            currentHL = gc1SkeletonSwatchHL;
            currentHL.SetActive(true);

            if (familyHasChanged)
            {
                FamilyChange();
            }
        }
        else if (family == Family.GumCare2)
        {
            currentPanel.SetActive(false);
            currentPanel = gc2;
            currentPanel.SetActive(true);

            SwitchFamilyHighlight();

            currentHL.SetActive(false);
            currentHL = gc2SkeletonSwatchHL;
            currentHL.SetActive(true);

            if (familyHasChanged)
            {
                FamilyChange();
            }
        }
        else if (family == Family.GumCare3)
        {
            currentPanel.SetActive(false);
            currentPanel = gc3;
            currentPanel.SetActive(true);

            SwitchFamilyHighlight();

            currentHL.SetActive(false);
            currentHL = gc3SkeletonSwatchHL;
            currentHL.SetActive(true);

            if (familyHasChanged)
            {
                FamilyChange();
            }
        }
        else if (family == Family.AdvancedCleaning1)
        {
            currentPanel.SetActive(false);
            currentPanel = ac1;
            currentPanel.SetActive(true);

            SwitchFamilyHighlight();

            currentHL.SetActive(false);
            currentHL = ac1SkeletonSwatchHL;
            currentHL.SetActive(true);

            if (familyHasChanged)
            {
                FamilyChange();
            }
        }
        else if (family == Family.AdvancedCleaning2)
        {
            currentPanel.SetActive(false);
            currentPanel = ac2;
            currentPanel.SetActive(true);

            SwitchFamilyHighlight();

            currentHL.SetActive(false);
            currentHL = ac2SkeletonSwatchHL;
            currentHL.SetActive(true);

            if (familyHasChanged)
            {
                FamilyChange();
            }
        }
        else if (family == Family.AdvancedCleaning3)
        {
            currentPanel.SetActive(false);
            currentPanel = ac3;
            currentPanel.SetActive(true);

            SwitchFamilyHighlight();

            currentHL.SetActive(false);
            currentHL = ac3SkeletonSwatchHL;
            currentHL.SetActive(true);

            if (familyHasChanged)
            {
                FamilyChange();
            }
        }
        else
        {
            Debug.LogError("No Family is selected!");
        }
        #endregion
    }

    private void SwitchFamilyHighlight()
    {
        if (currentPanel == wht1 || currentPanel == wht2 || currentPanel == wht3)
        {
            whtFamily.GetComponent<Image>().sprite = whiteningFamilyHL;
            gcFamily.GetComponent<Image>().sprite = gumCareFamily;
            acFamily.GetComponent<Image>().sprite = advCleaningFamily;
        }
        else if (currentPanel == gc1 || currentPanel == gc2 || currentPanel == gc3)
        {
            gcFamily.GetComponent<Image>().sprite = gumCareFamilyHL;
            whtFamily.GetComponent<Image>().sprite = whiteningFamily;
            acFamily.GetComponent<Image>().sprite = advCleaningFamily;
        }
        else if (currentPanel == ac1 || currentPanel == ac2 || currentPanel == ac3)
        {
            acFamily.GetComponent<Image>().sprite = advCleaningFamilyHL;
            gcFamily.GetComponent<Image>().sprite = gumCareFamily;
            whtFamily.GetComponent<Image>().sprite = whiteningFamily;
        }
    }
    
    public void FamilyChange()
    {
        if (family == Family.Whitening1)
        {
            activeHandle.transform.GetChild(0).gameObject.SetActive(false);
            currentBristleSwatchHL.SetActive(false);

            brushDisplayPanels = famDataWht1.brushDisplayPanels;
            brushHeadDisplayPanels = famDataWht1.brushHeadDisplayPanels;
            activeHandleColors = famDataWht1.handleColors;
            activeBristleColors = famDataWht1.handleHeadColors;
            activeHandleHead = famDataWht1.BristleHead;
            activeLargeBristleHeads = famDataWht1.largeBristleHeadSprites;

            activeHandle = brushDisplayPanels[0];
            activeHandle.transform.GetChild(0).gameObject.SetActive(true);

            activeHandleHead.GetComponent<Image>().sprite = activeLargeBristleHeads[0];

            currentBristleSwatchHL = wht1.transform.GetChild(2).transform.GetChild(1).GetChild(0).gameObject;
            currentBristleSwatchHL.SetActive(true);

            familyHasChanged = false;
        }
        else if (family == Family.Whitening2)
        {
            activeHandle.transform.GetChild(0).gameObject.SetActive(false);
            currentBristleSwatchHL.SetActive(false);

            brushDisplayPanels = famDataWht2.brushDisplayPanels;
            brushHeadDisplayPanels = famDataWht2.brushHeadDisplayPanels;
            activeHandleColors = famDataWht2.handleColors;
            activeBristleColors = famDataWht2.handleHeadColors;
            activeHandleHead = famDataWht2.BristleHead;
            activeLargeBristleHeads = famDataWht2.largeBristleHeadSprites;
            Debug.Log(activeLargeBristleHeads[0].name);
            Debug.Log(activeLargeBristleHeads[1].name);
            Debug.Log(activeLargeBristleHeads[2].name);

            activeHandle = brushDisplayPanels[0];
            activeHandle.transform.GetChild(0).gameObject.SetActive(true);

            activeHandleHead.GetComponent<Image>().sprite = activeLargeBristleHeads[0];

            currentBristleSwatchHL = wht2.transform.GetChild(2).transform.GetChild(1).GetChild(0).gameObject;
            currentBristleSwatchHL.SetActive(true);

            familyHasChanged = false;           
        }
        else if (family == Family.Whitening3)
        {
            activeHandle.transform.GetChild(0).gameObject.SetActive(false);
            currentBristleSwatchHL.SetActive(false);

            brushDisplayPanels = famDataWht3.brushDisplayPanels;
            brushHeadDisplayPanels = famDataWht3.brushHeadDisplayPanels;
            activeHandleColors = famDataWht3.handleColors;
            activeBristleColors = famDataWht3.handleHeadColors;
            activeHandleHead = famDataWht3.BristleHead;
            activeLargeBristleHeads = famDataWht3.largeBristleHeadSprites;

            activeHandle = brushDisplayPanels[0];
            activeHandle.transform.GetChild(0).gameObject.SetActive(true);

            activeHandleHead.GetComponent<Image>().sprite = activeLargeBristleHeads[0];

            currentBristleSwatchHL = wht3.transform.GetChild(2).transform.GetChild(1).GetChild(0).gameObject;
            currentBristleSwatchHL.SetActive(true);

            familyHasChanged = false;
        }
        else if (family == Family.GumCare1)
        {
            activeHandle.transform.GetChild(0).gameObject.SetActive(false);
            currentBristleSwatchHL.SetActive(false);

            brushDisplayPanels = famDataGc1.brushDisplayPanels;
            brushHeadDisplayPanels = famDataGc1.brushHeadDisplayPanels;
            activeHandleColors = famDataGc1.handleColors;
            activeBristleColors = famDataGc1.handleHeadColors;
            activeHandleHead = famDataGc1.BristleHead;
            activeLargeBristleHeads = famDataGc1.largeBristleHeadSprites;

            activeHandle = brushDisplayPanels[0];
            activeHandle.transform.GetChild(0).gameObject.SetActive(true);

            activeHandleHead.GetComponent<Image>().sprite = activeLargeBristleHeads[0];

            currentBristleSwatchHL = gc1.transform.GetChild(2).transform.GetChild(1).GetChild(0).gameObject;
            currentBristleSwatchHL.SetActive(true);

            familyHasChanged = false;
        }
        else if (family == Family.GumCare2)
        {
            activeHandle.transform.GetChild(0).gameObject.SetActive(false);
            currentBristleSwatchHL.SetActive(false);

            brushDisplayPanels = famDataGc2.brushDisplayPanels;
            brushHeadDisplayPanels = famDataGc2.brushHeadDisplayPanels;
            activeHandleColors = famDataGc2.handleColors;
            activeBristleColors = famDataGc2.handleHeadColors;
            activeHandleHead = famDataGc2.BristleHead;
            activeLargeBristleHeads = famDataGc2.largeBristleHeadSprites;

            activeHandle = brushDisplayPanels[0];
            activeHandle.transform.GetChild(0).gameObject.SetActive(true);

            activeHandleHead.GetComponent<Image>().sprite = activeLargeBristleHeads[0];

            currentBristleSwatchHL = gc2.transform.GetChild(2).transform.GetChild(1).GetChild(0).gameObject;
            currentBristleSwatchHL.SetActive(true);

            familyHasChanged = false;
        }
        else if (family == Family.GumCare3)
        {
            activeHandle.transform.GetChild(0).gameObject.SetActive(false);
            currentBristleSwatchHL.SetActive(false);

            brushDisplayPanels = famDataGc3.brushDisplayPanels;
            brushHeadDisplayPanels = famDataGc3.brushHeadDisplayPanels;
            activeHandleColors = famDataGc3.handleColors;
            activeHandleHead = famDataGc3.BristleHead;
            activeBristleColors = famDataGc3.handleHeadColors;

            activeLargeBristleHeads = famDataGc3.largeBristleHeadSprites;

            activeHandle = brushDisplayPanels[0];
            activeHandle.transform.GetChild(0).gameObject.SetActive(true);

            activeHandleHead.GetComponent<Image>().sprite = activeLargeBristleHeads[0];

            currentBristleSwatchHL = gc3.transform.GetChild(2).transform.GetChild(1).GetChild(0).gameObject;
            currentBristleSwatchHL.SetActive(true);

            familyHasChanged = false;
        }
        else if (family == Family.AdvancedCleaning1)
        {
            activeHandle.transform.GetChild(0).gameObject.SetActive(false);
            currentBristleSwatchHL.SetActive(false);

            brushDisplayPanels = famDataAc1.brushDisplayPanels;
            brushHeadDisplayPanels = famDataAc1.brushHeadDisplayPanels;
            activeHandleColors = famDataAc1.handleColors;
            activeBristleColors = famDataAc1.handleHeadColors;
            activeHandleHead = famDataAc1.BristleHead;
            activeLargeBristleHeads = famDataAc1.largeBristleHeadSprites;

            activeHandle = brushDisplayPanels[0];
            activeHandle.transform.GetChild(0).gameObject.SetActive(true);

            activeHandleHead.GetComponent<Image>().sprite = activeLargeBristleHeads[0];

            currentBristleSwatchHL = ac1.transform.GetChild(2).transform.GetChild(1).GetChild(0).gameObject;
            currentBristleSwatchHL.SetActive(true);

            familyHasChanged = false;
        }
        else if (family == Family.AdvancedCleaning2)
        {
            activeHandle.transform.GetChild(0).gameObject.SetActive(false);
            currentBristleSwatchHL.SetActive(false);

            brushDisplayPanels = famDataAc2.brushDisplayPanels;
            brushHeadDisplayPanels = famDataAc2.brushHeadDisplayPanels;
            activeHandleColors = famDataAc2.handleColors;
            activeBristleColors = famDataAc2.handleHeadColors;
            activeHandleHead = famDataAc2.BristleHead;
            activeLargeBristleHeads = famDataAc2.largeBristleHeadSprites;

            activeHandle = brushDisplayPanels[0];
            activeHandle.transform.GetChild(0).gameObject.SetActive(true);

            activeHandleHead.GetComponent<Image>().sprite = activeLargeBristleHeads[0];

            currentBristleSwatchHL = ac2.transform.GetChild(2).transform.GetChild(1).GetChild(0).gameObject;
            currentBristleSwatchHL.SetActive(true);

            familyHasChanged = false;
        }
        else if (family == Family.AdvancedCleaning3)
        {
            activeHandle.transform.GetChild(0).gameObject.SetActive(false);
            currentBristleSwatchHL.SetActive(false);

            brushDisplayPanels = famDataAc3.brushDisplayPanels;
            brushHeadDisplayPanels = famDataAc3.brushHeadDisplayPanels;
            activeHandleColors = famDataAc3.handleColors;
            activeBristleColors = famDataAc3.handleHeadColors;
            activeHandleHead = famDataAc3.BristleHead;
            activeLargeBristleHeads = famDataAc3.largeBristleHeadSprites;

            activeHandle = brushDisplayPanels[0];
            activeHandle.transform.GetChild(0).gameObject.SetActive(true);

            activeHandleHead.GetComponent<Image>().sprite = activeLargeBristleHeads[0];

            currentBristleSwatchHL = ac3.transform.GetChild(2).transform.GetChild(1).GetChild(0).gameObject;
            currentBristleSwatchHL.SetActive(true);

            familyHasChanged = false;
        }
    }

}
