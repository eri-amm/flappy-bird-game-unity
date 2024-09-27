using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bases : MonoBehaviour
{
    public float speed;
    public GameObject shadowPanel;
    public Material shadow;
    public MeshRenderer shadowRenderer;
    public Color color;
    Vector2 offset;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        offset = new Vector2(Time.time * speed,0);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
        shadow.color = color;
    }
}
