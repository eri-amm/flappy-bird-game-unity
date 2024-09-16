using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;

public class panelManager : MonoBehaviour
{
    //all of these things should be done when the game boots up and the actual settings are also getting applied
    public GameObject AudioP, CycleP, SkinP;
    public scene_managerr scene_Managerr;
    public SkinCHN skinScr;
    public switchLogic switchLogic;
    public sceneryManager sceneryManager;

    public void Start()
    {
        skinP();
    }

    public void skinP()
    {

        AudioP.SetActive(false);
        CycleP.SetActive(false);

        SkinP.SetActive(true);

        GameObject.FindGameObjectWithTag("UIimage").GetComponent<Image>().overrideSprite = skinScr.GetSkin(PlayerPrefs.GetInt("SkinNum"));
        skinScr.skinNum = PlayerPrefs.GetInt("SkinNum");
        skinScr.skinName.text = skinScr.GetSkinName(PlayerPrefs.GetInt("SkinNum"));
        
    }
    public void audioP()
    {

        SkinP.SetActive(false);
        CycleP.SetActive(false);

        AudioP.SetActive(true);
        
        switchLogic.FlappyB.image.overrideSprite= switchLogic.GetSwitch(PlayerPrefs.GetInt("FlappyVol"));
        switchLogic.iconNumF = PlayerPrefs.GetInt("FlappyVol");

        switchLogic.MusicB.image.overrideSprite = switchLogic.GetSwitch(PlayerPrefs.GetInt("MusicVol"));
        switchLogic.iconNumM = PlayerPrefs.GetInt("MusicVol");

        switchLogic.PointsB.image.overrideSprite = switchLogic.GetSwitch(PlayerPrefs.GetInt("PointsVol"));
        switchLogic.iconNumP = PlayerPrefs.GetInt("PointsVol");
    }
    public void cycleP()
    {
        AudioP.SetActive(false);
        SkinP.SetActive(false);

        CycleP.SetActive(true);

        GameObject.FindGameObjectWithTag("UIimage").GetComponent<MeshRenderer>().material = sceneryManager.GetSkyScenery(PlayerPrefs.GetInt("SceneryNum"));
        sceneryManager.sceneryNum = Convert.ToInt16 (PlayerPrefs.GetInt("SceneryNum"));

    }
}
