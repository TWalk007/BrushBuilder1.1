using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandleColorSwapper : MonoBehaviour
{

    private ImageManager imageManager;
    private CodeGeneratorUI codeChanger;

    void Start()
    {
        imageManager = GameObject.FindObjectOfType<ImageManager>();
        codeChanger = GameObject.FindObjectOfType<CodeGeneratorUI>();
    }

    public void HandleClick()
    {
        imageManager.activeHandle.transform.GetChild(0).gameObject.SetActive(false);
        imageManager.activeHandle = this.gameObject;
        imageManager.activeHandle.transform.GetChild(0).gameObject.SetActive(true);
    }

    public void ChangeHandleColor()
    {
        CheckSwatchTag(this.gameObject);
    }

    private void CheckSwatchTag(GameObject go)
    {
        if (go.tag == "HandleColorSwatch1")
        {

            //Debug.Log("This swatch tag is: " + go.tag);
            imageManager.activeHandle.GetComponent<Image>().sprite = imageManager.activeHandleColors[0];

            if (imageManager.activeHandle.tag == "HandleDisplayA")
            {
                codeChanger.codeHasChanged = true;
                codeChanger.handleColorATemp = codeChanger.handleColor[0];
            }
            else if (imageManager.activeHandle.tag == "HandleDisplayB")
            {
                codeChanger.codeHasChanged = true;
                codeChanger.handleColorBTemp = codeChanger.handleColor[0];
            }
            else if (imageManager.activeHandle.tag == "HandleDisplayC")
            {
                codeChanger.codeHasChanged = true;
                codeChanger.handleColorCTemp = codeChanger.handleColor[0];
            }
            else if (imageManager.activeHandle.tag == "HandleDisplayD")
            {
                codeChanger.codeHasChanged = true;
                codeChanger.handleColorDTemp = codeChanger.handleColor[0];
            }
        }
        else if (go.tag == "HandleColorSwatch2")
        {
            //Debug.Log("This swatch tag is: " + go.tag);
            imageManager.activeHandle.GetComponent<Image>().sprite = imageManager.activeHandleColors[1];

            if (imageManager.activeHandle.tag == "HandleDisplayA")
            {
                codeChanger.codeHasChanged = true;
                codeChanger.handleColorATemp = codeChanger.handleColor[1];
            }
            else if (imageManager.activeHandle.tag == "HandleDisplayB")
            {
                codeChanger.codeHasChanged = true;
                codeChanger.handleColorBTemp = codeChanger.handleColor[1];
            }
            else if (imageManager.activeHandle.tag == "HandleDisplayC")
            {
                codeChanger.codeHasChanged = true;
                codeChanger.handleColorCTemp = codeChanger.handleColor[1];
            }
            else if (imageManager.activeHandle.tag == "HandleDisplayD")
            {
                codeChanger.codeHasChanged = true;
                codeChanger.handleColorDTemp = codeChanger.handleColor[1];
            }
        }
        else if (go.tag == "HandleColorSwatch3")
        {
            imageManager.activeHandle.GetComponent<Image>().sprite = imageManager.activeHandleColors[2];

            if (imageManager.activeHandle.tag == "HandleDisplayA")
            {
                codeChanger.codeHasChanged = true;
                codeChanger.handleColorATemp = codeChanger.handleColor[2];
            }
            else if (imageManager.activeHandle.tag == "HandleDisplayB")
            {
                codeChanger.codeHasChanged = true;
                codeChanger.handleColorBTemp = codeChanger.handleColor[2];
            }
            else if (imageManager.activeHandle.tag == "HandleDisplayC")
            {
                codeChanger.codeHasChanged = true;
                codeChanger.handleColorCTemp = codeChanger.handleColor[2];
            }
            else if (imageManager.activeHandle.tag == "HandleDisplayD")
            {
                codeChanger.codeHasChanged = true;
                codeChanger.handleColorDTemp = codeChanger.handleColor[2];
            }
        }
        else if (go.tag == "HandleColorSwatch4")
        {
            imageManager.activeHandle.GetComponent<Image>().sprite = imageManager.activeHandleColors[3];

            if (imageManager.activeHandle.tag == "HandleDisplayA")
            {
                codeChanger.codeHasChanged = true;
                codeChanger.handleColorATemp = codeChanger.handleColor[3];
            }
            else if (imageManager.activeHandle.tag == "HandleDisplayB")
            {
                codeChanger.codeHasChanged = true;
                codeChanger.handleColorBTemp = codeChanger.handleColor[3];
            }
            else if (imageManager.activeHandle.tag == "HandleDisplayC")
            {
                codeChanger.codeHasChanged = true;
                codeChanger.handleColorCTemp = codeChanger.handleColor[3];
            }
            else if (imageManager.activeHandle.tag == "HandleDisplayD")
            {
                codeChanger.codeHasChanged = true;
                codeChanger.handleColorDTemp = codeChanger.handleColor[3];
            }
        }
        else if (go.tag == "HandleColorSwatch5")
        {
            imageManager.activeHandle.GetComponent<Image>().sprite = imageManager.activeHandleColors[4];

            if (imageManager.activeHandle.tag == "HandleDisplayA")
            {
                codeChanger.codeHasChanged = true;
                codeChanger.handleColorATemp = codeChanger.handleColor[4];
            }
            else if (imageManager.activeHandle.tag == "HandleDisplayB")
            {
                codeChanger.codeHasChanged = true;
                codeChanger.handleColorBTemp = codeChanger.handleColor[4];
            }
            else if (imageManager.activeHandle.tag == "HandleDisplayC")
            {
                codeChanger.codeHasChanged = true;
                codeChanger.handleColorCTemp = codeChanger.handleColor[4];
            }
            else if (imageManager.activeHandle.tag == "HandleDisplayD")
            {
                codeChanger.codeHasChanged = true;
                codeChanger.handleColorDTemp = codeChanger.handleColor[4];
            }
        }
        else if (go.tag == "HandleColorSwatch6")
        {
            imageManager.activeHandle.GetComponent<Image>().sprite = imageManager.activeHandleColors[5];

            if (imageManager.activeHandle.tag == "HandleDisplayA")
            {
                codeChanger.codeHasChanged = true;
                codeChanger.handleColorATemp = codeChanger.handleColor[5];
            }
            else if (imageManager.activeHandle.tag == "HandleDisplayB")
            {
                codeChanger.codeHasChanged = true;
                codeChanger.handleColorBTemp = codeChanger.handleColor[5];
            }
            else if (imageManager.activeHandle.tag == "HandleDisplayC")
            {
                codeChanger.codeHasChanged = true;
                codeChanger.handleColorCTemp = codeChanger.handleColor[5];
            }
            else if (imageManager.activeHandle.tag == "HandleDisplayD")
            {
                codeChanger.codeHasChanged = true;
                codeChanger.handleColorDTemp = codeChanger.handleColor[5];
            }
        }
        else if (go.tag == "HandleColorSwatch7")
        {
            imageManager.activeHandle.GetComponent<Image>().sprite = imageManager.activeHandleColors[6];

            if (imageManager.activeHandle.tag == "HandleDisplayA")
            {
                codeChanger.codeHasChanged = true;
                codeChanger.handleColorATemp = codeChanger.handleColor[6];
            }
            else if (imageManager.activeHandle.tag == "HandleDisplayB")
            {
                codeChanger.codeHasChanged = true;
                codeChanger.handleColorBTemp = codeChanger.handleColor[6];
            }
            else if (imageManager.activeHandle.tag == "HandleDisplayC")
            {
                codeChanger.codeHasChanged = true;
                codeChanger.handleColorCTemp = codeChanger.handleColor[6];
            }
            else if (imageManager.activeHandle.tag == "HandleDisplayD")
            {
                codeChanger.codeHasChanged = true;
                codeChanger.handleColorDTemp = codeChanger.handleColor[6];
            }
        }
        else if (go.tag == "HandleColorSwatch8")
        {
            imageManager.activeHandle.GetComponent<Image>().sprite = imageManager.activeHandleColors[7];

            if (imageManager.activeHandle.tag == "HandleDisplayA")
            {
                codeChanger.codeHasChanged = true;
                codeChanger.handleColorATemp = codeChanger.handleColor[7];
            }
            else if (imageManager.activeHandle.tag == "HandleDisplayB")
            {
                codeChanger.codeHasChanged = true;
                codeChanger.handleColorBTemp = codeChanger.handleColor[7];
            }
            else if (imageManager.activeHandle.tag == "HandleDisplayC")
            {
                codeChanger.codeHasChanged = true;
                codeChanger.handleColorCTemp = codeChanger.handleColor[7];
            }
            else if (imageManager.activeHandle.tag == "HandleDisplayD")
            {
                codeChanger.codeHasChanged = true;
                codeChanger.handleColorDTemp = codeChanger.handleColor[7];
            }
        }
        else
        {
            Debug.LogError("This swatch is missing a tag!");
        }
    }
}
