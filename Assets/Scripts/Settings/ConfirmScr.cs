using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ConfirmScr : MonoBehaviour
{
    public SkinCHN skinScr;
    public switchLogic switchScr;
    public sceneryManager sceneryManager;
    public void confirm()
    {
        
        PlayerPrefs.SetInt("SkinNum", skinScr.skinNum);
        PlayerPrefs.SetInt("MusicVol", switchScr.iconNumM);
        PlayerPrefs.SetInt("FlappyVol", switchScr.iconNumF);
        PlayerPrefs.SetInt("PointsVol", switchScr.iconNumP);
        PlayerPrefs.SetInt("SceneryNum", sceneryManager.sceneryNum);
    }

}
