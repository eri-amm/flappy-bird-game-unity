using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scene_managerr : MonoBehaviour
{
    public GameObject panel,menu;
    public void change(string Scene_name)
    {
        SceneManager.LoadScene(Scene_name);
    }
    public void panel_Open()
    {
        panel.SetActive(true);
        menu.SetActive(false);
    }

    public void panel_close()
    {
        panel.SetActive(false);
        menu.SetActive(true);
    }
}
