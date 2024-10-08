using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class switchLogic : MonoBehaviour
{
    public Sprite offIcon,onIcon;
    public int iconNumM, iconNumF, iconNumP;
    public Button MusicB,FlappyB,PointsB;
    public ostmanager ostmanager;
    public void musicB()
    {

        if (iconNumM == 0)
        {
            MusicB.image.overrideSprite = onIcon;
            iconNumM = 1;
            ostmanager.play();

        }

        else if (iconNumM == 1)
        {
            MusicB.image.overrideSprite = offIcon;
            iconNumM = 0;
        }
        PlayerPrefs.SetInt("MusicVol", iconNumM);
        
    }

    public void flappyB()
    {

        if (iconNumF == 0)
        {
            FlappyB.image.overrideSprite = onIcon;
            iconNumF = 1;
        }

        else if (iconNumF == 1)
        {
            FlappyB.image.overrideSprite = offIcon;
            iconNumF = 0;
        }
        PlayerPrefs.SetInt("FlappyVol", iconNumF);
       
    }

    public void pointsB()
    {

        if (iconNumP == 0)
        {
            PointsB.image.overrideSprite = onIcon;
            iconNumP = 1;
        }

        else if (iconNumP == 1)
        {
            PointsB.image.overrideSprite = offIcon;
            iconNumP = 0;
        }
        PlayerPrefs.SetInt("PointsVol", iconNumP);
    }
    public Sprite GetSwitch(int curr_state)
    {
        if (curr_state == 0)
        {
            return offIcon;
        }

        else 
        { 
            return onIcon;
        }

    }
}
