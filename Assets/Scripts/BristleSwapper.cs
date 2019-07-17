using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BristleSwapper : MonoBehaviour
{
    private ImageManager imageManager;
    private CodeGeneratorUI codeChanger;

    void Start()
    {
        imageManager = GameObject.FindObjectOfType<ImageManager>();
        codeChanger = GameObject.FindObjectOfType<CodeGeneratorUI>();
    }


    public void SwapBristles()
    {
        imageManager.currentBristleSwatchHL.SetActive(false);
        CheckSwatchTag(this.gameObject);
        imageManager.currentBristleSwatchHL.SetActive(true);
    }

    private void CheckSwatchTag(GameObject go)
    {
        if (go.tag == "BristleSwatchA")
        {
            imageManager.currentBristleSwatchHL = this.transform.GetChild(0).gameObject;
            foreach (GameObject x in imageManager.brushHeadDisplayPanels)
            {
                x.GetComponent<Image>().sprite = imageManager.activeBristleColors[0];
                imageManager.activeHandleHead.GetComponent<Image>().sprite = imageManager.activeLargeBristleHeads[0];
                codeChanger.codeHasChanged = true;
                codeChanger.bristleCodeTemp = codeChanger.bristleCode[0];
            }
        }
        else if (go.tag == "BristleSwatchB")
        {
            imageManager.currentBristleSwatchHL = this.transform.GetChild(0).gameObject;
            foreach (GameObject x in imageManager.brushHeadDisplayPanels)
            {
                x.GetComponent<Image>().sprite = imageManager.activeBristleColors[1];
                imageManager.activeHandleHead.GetComponent<Image>().sprite = imageManager.activeLargeBristleHeads[1];
                codeChanger.codeHasChanged = true;
                codeChanger.bristleCodeTemp = codeChanger.bristleCode[1];
            }
        }
        else if (go.tag == "BristleSwatchC")
        {
            imageManager.currentBristleSwatchHL = this.transform.GetChild(0).gameObject;
            foreach (GameObject x in imageManager.brushHeadDisplayPanels)
            {
                x.GetComponent<Image>().sprite = imageManager.activeBristleColors[2];
                imageManager.activeHandleHead.GetComponent<Image>().sprite = imageManager.activeLargeBristleHeads[2];
                codeChanger.codeHasChanged = true;
                codeChanger.bristleCodeTemp = codeChanger.bristleCode[2];
            }
        }
    }
}
