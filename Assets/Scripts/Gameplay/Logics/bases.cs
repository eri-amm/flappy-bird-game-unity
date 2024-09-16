using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bases : MonoBehaviour
{
    public float speed;
    public GameObject shadowPanel;
    Vector2 offset;

     void Start()
    {
        if (PlayerPrefs.GetInt("SceneryNum") == 1)
        {
            shadowPanel.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        offset = new Vector2(Time.time * speed,0);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
