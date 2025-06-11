using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class switchLogic : MonoBehaviour
{
    public Sprite offIcon,onIcon;
    public float iconNumM, iconNumF, iconNumP;
    public Button MusicB,FlappyB,PointsB;
    public ostmanager ostmanager;
    public void musicB()
    {

        if (iconNumM < 0.1f)
        {
            MusicB.image.overrideSprite = onIcon;
            iconNumM = 0.2f;
            PlayerPrefs.SetFloat("MusicVol", iconNumM);
            ostmanager.play();
        }

        else
        {
            MusicB.image.overrideSprite = offIcon;
            iconNumM = 0f;
            PlayerPrefs.SetFloat("MusicVol", iconNumM);
        }
        
    }

    public void flappyB()
    {

        if (iconNumF < 0.1f)
        {
            FlappyB.image.overrideSprite = onIcon;
            iconNumF = 0.2f;
        }

        else
        {
            FlappyB.image.overrideSprite = offIcon;
            iconNumF = 0f;
        }
        PlayerPrefs.SetFloat("FlappyVol", iconNumF);

    }

    public void pointsB()
    {

        if (iconNumP < 0.0001f)
        {
            PointsB.image.overrideSprite = onIcon;
            iconNumP = 0.1f;
        }

        else
        {
            PointsB.image.overrideSprite = offIcon;
            iconNumP = 0f;
        }
        PlayerPrefs.SetFloat("PointsVol", iconNumP);
    }
    public Sprite GetSwitch(float curr_state)
    {
        if (curr_state <0.1f)
        {
            return offIcon;
        }

        else 
        { 
            return onIcon;
        }

    }
}
