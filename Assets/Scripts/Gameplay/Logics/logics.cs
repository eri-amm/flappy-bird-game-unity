using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class logics : MonoBehaviour
{
    public int score=0;
    public Text scoreT;
    public AudioSource point,ost;
    public Button pauseB;
    public Sprite pauseS, playS;
    public GameObject gameOvers,startMenu,gameplay,scoreTx;

    void Start()
    {
        point.volume = PlayerPrefs.GetInt("PointsVol");
        ost.volume = PlayerPrefs.GetInt("MusicVol");
        ost.Play();
    }
    public void inc_scr()
    {
        score++;
        point.Play();
        scoreT.text = score.ToString();
    }
    public void play()
    {
        startMenu.SetActive(false);
        gameplay.SetActive(true);
        scoreTx.SetActive(true);
    }
    public void pause()
    {
        if (Time.timeScale != 0)
        {
            Time.timeScale = 0;
            pauseB.image.overrideSprite = playS;
        }
        else
        {
            Time.timeScale = 1;
            pauseB.image.overrideSprite = pauseS;
        }
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
