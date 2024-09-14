using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scene_managerr : MonoBehaviour
{
    public void change(string Scene_name)
    {
        SceneManager.LoadScene(Scene_name);
    }
}
