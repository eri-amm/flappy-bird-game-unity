using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class logics : MonoBehaviour
{
    public int score=0;
    public Text scoreT;
    public AudioSource point;
    public GameObject gameOvers;

    public void inc_scr()
    {
        score++;
        point.Play();
        scoreT.text = score.ToString();
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
    public void gameOver()
    {
        gameOvers.SetActive(true);
    }
}
