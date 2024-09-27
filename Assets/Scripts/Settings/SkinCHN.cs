
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class SkinCHN : MonoBehaviour
{
    public Sprite[] skins; 
    public Text skinName;
    public int skinNum = 0;
    public void right()
    {
        if (skinNum == 2)
            skinNum = 0;

        else skinNum++;

        GameObject.FindGameObjectWithTag("UIimage").GetComponent<Image>().overrideSprite=skins[skinNum];
        skinName.text = GetSkinName(skinNum);
        PlayerPrefs.SetInt("SkinNum", skinNum);
    }
    public void left ()
    {
        if (skinNum == 0)
            skinNum = 2;

        else skinNum--;

        GameObject.FindGameObjectWithTag("UIimage").GetComponent<Image>().overrideSprite = skins[skinNum];
        skinName.text = GetSkinName(skinNum);
        PlayerPrefs.SetInt("SkinNum", skinNum);
    }
    public Sprite GetSkin(int curr_skin)
    {
        return skins[curr_skin];
    }
    public string GetSkinName(int curr_skin) {

        if (curr_skin == 0)
        {
            return "Gold";
        }

        else if (curr_skin == 1)
        {
            return "Sky";
        }

        else
        {
            return "Ruby";
        }

    }
}
