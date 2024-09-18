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
            return new Vector3(79.14f, 41f, 1);
        }
           
        else if (curr_scenery == 1)
        {
            return new Vector3(30.09f, 55f, 1);
        }

        else if (curr_scenery == 0)
        {
            return new Vector3(30.09f, 44.1f, 1);
        }

        else
        {
            return new Vector3(94.01f, 42.82f, 1);
        }
    }

    public Vector3 getSkyPos(int curr_scenery) 
    {
        if (curr_scenery == 3)
        {
            return new Vector3(-1.22f, 4f, 4f);
        }
           
        else if (curr_scenery == 1)
        {
            return new Vector3(-1.22f, -1.09f, 3.17f);
        }

        else if (curr_scenery == 0)
        {
            return new Vector3(-1.22f, 4.89f, 3.17f);
        }

        else
        {
            return new Vector3(24.5f, 3.4f, 3.6f);
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
            return new Vector3(41.06f, 9.373557f,1);
        }
        else  
        {
           return new Vector3(74.43f,9.373557f,1);
        }
    }
}
