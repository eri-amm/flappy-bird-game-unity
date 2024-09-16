using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bootManager : MonoBehaviour
{
    public float timer = 0;
    // Update is called once per frame
    void Update()
    {

        if (timer < 2)
        {
            timer = timer + Time.deltaTime;
        }
          
        else
        {
            SceneManager.LoadScene("Main");
        }
        
    }
}
