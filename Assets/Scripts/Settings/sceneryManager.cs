using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class sceneryManager : MonoBehaviour
{
    public Material[] scenerylist;
    public Material[] groundlist;
    public short sceneryNum=0;
    
    public void right()
    {

        if (sceneryNum != 3)
            sceneryNum++;

        else sceneryNum = 0;

        GameObject.FindGameObjectWithTag("UIimage").GetComponent<MeshRenderer>().material = scenerylist[sceneryNum];
        PlayerPrefs.SetInt("SceneryNum",sceneryNum);
    }

    public void left()
    {
        if (sceneryNum != 0)
            sceneryNum--;

        else sceneryNum = 3;

        GameObject.FindGameObjectWithTag("UIimage").GetComponent<MeshRenderer>().material = scenerylist[sceneryNum];
        PlayerPrefs.SetInt("SceneryNum", sceneryNum);
    }

    public Material GetSkyScenery(int curr_scenery)
    {
        return scenerylist[curr_scenery];
    }
    public Vector3 getSkySize(int curr_scenery)
    {
        if (curr_scenery == 3)
        {
            return new Vector3(111.48f, 58.97f, 1);
        }
           
        else if (curr_scenery == 1)
        {
            return new Vector3(37.255f, 73.51315f, 1);
        }

        else if (curr_scenery == 0)
        {
            return new Vector3(40.55f, 58.61269f, 1);
        }

        else
        {
            return new Vector3(124.92f, 61.68f, 1);
        }
    }

    public Vector3 getSkyPos(int curr_scenery) 
    {
        if (curr_scenery == 3)
        {
            return new Vector3(0.91f, 8.07f, 4f);
        }
           
        else if (curr_scenery == 1)
        {
            return new Vector3(-1.45f, -0.266f, 3.17f);
        }

        else if (curr_scenery == 0)
        {
            return new Vector3(-0.76f, 7.4f, 3.17f);
        }

        else
        {
            return new Vector3(9.04f, 8.35f, 3.6f);
        }
    }

    public Material getGroundMat(int curr_scenery)
    {
        return groundlist[curr_scenery];
    }

    public Vector3 getGroundSize(int curr_scenery)
    {
        if (curr_scenery == 0 || curr_scenery == 1)
        {
            return new Vector3(41.06f, 12.15858f, 1);
        }
        else if (curr_scenery == 2)
        {
            return new Vector3(74.43f, 13.193f, 1);
        }
        else {
            return new Vector3(74.43f, 13.54758f, 1);
        }
    }
}
