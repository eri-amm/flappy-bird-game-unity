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
