using UnityEngine;
using UnityEngine.UI;

public class SkeletonSwapper : MonoBehaviour
{
    private ImageManager imageManager;
    private CodeGeneratorUI codeChanger;

    void Start()
    {
        imageManager = GameObject.FindObjectOfType<ImageManager>();
        codeChanger = GameObject.FindObjectOfType<CodeGeneratorUI>();
    }

    // Update is called once per frame
    public void ChangeSkeleton()
    {
        CheckSwatch(this.gameObject.GetComponent<Image>().sprite);
    }

    private void CheckSwatch(Sprite sprite)
    {
        if (sprite.name == "UI_Family_Wht_Swatch-A")
        {
            imageManager.family = ImageManager.Family.Whitening1;
            imageManager.familyHasChanged = true;
            codeChanger.codeHasChanged = true;
            codeChanger.familyCodeTemp = codeChanger.familyCode[0];
            codeChanger.FamilyCodeReset();
        }
        else if (sprite.name == "UI_Family_Wht_Swatch-B")
        {
            imageManager.family = ImageManager.Family.Whitening2;
            imageManager.familyHasChanged = true;
            codeChanger.codeHasChanged = true;
            codeChanger.familyCodeTemp = codeChanger.familyCode[1];
            codeChanger.FamilyCodeReset();
        }
        else if (sprite.name == "UI_Family_Wht_Swatch-C")
        {
            imageManager.family = ImageManager.Family.Whitening3;
            imageManager.familyHasChanged = true;
            codeChanger.codeHasChanged = true;
            codeChanger.familyCodeTemp = codeChanger.familyCode[2];
            codeChanger.FamilyCodeReset();
        }
        else if (sprite.name == "UI_Family_GC_Swatch-A")
        {
            imageManager.family = ImageManager.Family.GumCare1;
            imageManager.familyHasChanged = true;
            codeChanger.codeHasChanged = true;
            codeChanger.familyCodeTemp = codeChanger.familyCode[3];
            codeChanger.FamilyCodeReset();
        }
        else if (sprite.name == "UI_Family_GC_Swatch-B")
        {
            imageManager.family = ImageManager.Family.GumCare2;
            imageManager.familyHasChanged = true;
            codeChanger.codeHasChanged = true;
            codeChanger.familyCodeTemp = codeChanger.familyCode[4];
            codeChanger.FamilyCodeReset();
        }
        else if (sprite.name == "UI_Family_GC_Swatch-C")
        {
            imageManager.family = ImageManager.Family.GumCare3;
            imageManager.familyHasChanged = true;
            codeChanger.codeHasChanged = true;
            codeChanger.familyCodeTemp = codeChanger.familyCode[5];
            codeChanger.FamilyCodeReset();
        }
        else if (sprite.name == "UI_Family_AC_Swatch-A")
        {
            imageManager.family = ImageManager.Family.AdvancedCleaning1;
            imageManager.familyHasChanged = true;
            codeChanger.codeHasChanged = true;
            codeChanger.familyCodeTemp = codeChanger.familyCode[6];
            codeChanger.FamilyCodeReset();
        }
        else if (sprite.name == "UI_Family_AC_Swatch-B")
        {
            imageManager.family = ImageManager.Family.AdvancedCleaning2;
            imageManager.familyHasChanged = true;
            codeChanger.codeHasChanged = true;
            codeChanger.familyCodeTemp = codeChanger.familyCode[7];
            codeChanger.FamilyCodeReset();
        }
        else if (sprite.name == "UI_Family_AC_Swatch-C")
        {
            imageManager.family = ImageManager.Family.AdvancedCleaning3;
            imageManager.familyHasChanged = true;
            codeChanger.codeHasChanged = true;
            codeChanger.familyCodeTemp = codeChanger.familyCode[8];
            codeChanger.FamilyCodeReset();
        }
    }

   
}
