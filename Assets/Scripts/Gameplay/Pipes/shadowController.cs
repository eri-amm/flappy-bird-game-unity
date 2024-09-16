using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.UI;

public class shadowController : MonoBehaviour
{

    SpriteRenderer shadow;

    public void Start()
    {
        shadow = GetComponent<SpriteRenderer>();
        if (PlayerPrefs.GetInt("SceneryNum")==1)
        {
            shadow.color = new Color(0.64f, 0.64f, 0.64f);
        }
        else if (PlayerPrefs.GetInt("SceneryNum") == 3)
        {
            shadow.color = new Color(0.945098f, 0.945098f, 0.945098f);
        }
        else 
        {
            shadow.color = new Color(1, 1, 1);
        }
    }
}
