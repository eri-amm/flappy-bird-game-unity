using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class panelManager : MonoBehaviour
{
    
    public GameObject AudioP, CycleP, SkinP;
    public scene_managerr scene_Managerr;
    public SkinCHN skinScr;
    public switchLogic switchLogic;
    public sceneryManager sceneryManager;
    public Image skinF, cycleF, audioF;

    public void Start()
    {
        skinP();
    }

    public void skinP()
    {

        AudioP.SetActive(false);
        CycleP.SetActive(false);

        audioF.color = new Color(0, 1, 0.9843137f);
        cycleF.color = new Color(0, 1, 0.9843137f);

        SkinP.SetActive(true);

        skinF.color = new Color(0,1, 0.07569122f);
        GameObject.FindGameObjectWithTag("UIimage").GetComponent<Image>().overrideSprite = skinScr.GetSkin(PlayerPrefs.GetInt("SkinNum"));
        skinScr.skinNum = PlayerPrefs.GetInt("SkinNum");
        skinScr.skinName.text = skinScr.GetSkinName(PlayerPrefs.GetInt("SkinNum"));
        
    }
    public void audioP()
    {

        SkinP.SetActive(false);
        CycleP.SetActive(false);
        skinF.color = new Color(0, 1, 0.9843137f);
        cycleF.color = new Color(0, 1, 0.9843137f);

        AudioP.SetActive(true);

        audioF.color = new Color(0, 1, 0.07569122f);

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

        skinF.color = new Color(0, 1, 0.9843137f);
        audioF.color = new Color(0, 1, 0.9843137f);

        CycleP.SetActive(true);

        cycleF.color = new Color(0, 1, 0.07569122f);
        GameObject.FindGameObjectWithTag("UIimage").GetComponent<MeshRenderer>().material = sceneryManager.GetSkyScenery(PlayerPrefs.GetInt("SceneryNum"));
        sceneryManager.sceneryNum = Convert.ToInt16 (PlayerPrefs.GetInt("SceneryNum"));

    }
}
