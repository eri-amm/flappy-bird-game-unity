using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class sceneryManager : MonoBehaviour
{
    public Sprite[] scenerylist;
    public short sceneryNum=0;
    
    public void right()
    {

        if (sceneryNum != 4)
            sceneryNum++;

        else sceneryNum = 0;

         GameObject.FindGameObjectWithTag("UIimage").GetComponent<Image>().overrideSprite= scenerylist[sceneryNum];
    }

    public void left()
    {
        if (sceneryNum != 0)
            sceneryNum--;

        else sceneryNum = 4;

        GameObject.FindGameObjectWithTag("UIimage").GetComponent<Image>().overrideSprite = scenerylist[sceneryNum];
    }

    public Sprite GetScenery(int curr_scenery)
    {
        return scenerylist[curr_scenery];
    }

}
