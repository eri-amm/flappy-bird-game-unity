using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class checkUpdate : MonoBehaviour
{
    public static bool isUpdated = true;
    void Start()
    {
        StartCoroutine(GetVersion());
    }
    IEnumerator GetVersion()
    {
        UnityWebRequest web = UnityWebRequest.Get("https://thisiserfanswebsiteheh.on.drv.tw/www.barusu.run.place/pages/version.txt");
        yield return web.SendWebRequest();

        if (web.result != UnityWebRequest.Result.Success)
        {
            Debug.Log("Could not connect");
        }
        else
        {
            if (web.downloadHandler.text == Application.version)
            {
                Debug.Log("Up to date");

            }
            else
            {
                Debug.Log("Old version");
                isUpdated = false;
            }
        }

    }
}
