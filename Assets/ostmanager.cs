using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ostmanager : MonoBehaviour
{
    public static ostmanager instance;
    public AudioSource ost;
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(ost);
        }
        else
        {
            Destroy(ost);
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        instance.ost.volume = PlayerPrefs.GetInt("MusicVol");
        ost.Play();
    }

    void Update()
    {
        instance.ost.volume = PlayerPrefs.GetInt("MusicVol");
    }
    public void play()
    {
        instance.ost.Play();
    }
}
