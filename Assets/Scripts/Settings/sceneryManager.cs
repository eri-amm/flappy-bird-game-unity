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
            return new Vector3(111.48f, 57.81f, 1);
        }
           
        else if (curr_scenery == 1)
        {
            return new Vector3(36.03f, 71.86f, 1);
        }

        else if (curr_scenery == 0)
        {
            return new Vector3(40.55f, 56.9f, 1);
        }

        else
        {
            return new Vector3(124.92f, 58.462f, 1);
        }
    }

    public Vector3 getSkyPos(int curr_scenery) 
    {
        if (curr_scenery == 3)
        {
            return new Vector3(0.91f, 6.72f, 4f);
        }
           
        else if (curr_scenery == 1)
        {
            return new Vector3(-1.45f, -0.77f, 3.17f);
        }

        else if (curr_scenery == 0)
        {
            return new Vector3(-0.76f, 6.35f, 3.17f);
        }

        else
        {
            return new Vector3(9.04f, 5.62f, 3.6f);
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
            return new Vector3(41.06f, 10.66f, 1);
        }
        else if (curr_scenery == 2)
        {
            return new Vector3(74.43f, 10.3f, 1);
        }
        else {
            return new Vector3(74.43f, 11.05f, 1);
        }
    }
}
