using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class logics : MonoBehaviour
{
    public int score=0;
    public sceneryManager sceneryManager;
    public MeshRenderer sky,ground;
    public Text scoreT,highScore,boardScore,boardHigh;
    public AudioSource point,ost;
    public Button pauseB;
    public Image medal;
    public Sprite pauseS, playS,bronze,silver,gold,plat;
    public GameObject gameOvers,startMenu,gameplay,scoreTx,newHigh,Medal,flappy,endB;

    void Start()
    {
        point.volume = PlayerPrefs.GetInt("PointsVol");
        ost.volume = PlayerPrefs.GetInt("MusicVol");
        ost.Play();
        highScore.text = Convert.ToString(PlayerPrefs.GetInt("HighScore"));
        sky.material = sceneryManager.GetSkyScenery(PlayerPrefs.GetInt("SceneryNum"));
        sky.transform.localScale = sceneryManager.getSkySize(PlayerPrefs.GetInt("SceneryNum"));
        sky.transform.localPosition = sceneryManager.getSkyPos(PlayerPrefs.GetInt("SceneryNum"));
        ground.material = sceneryManager.getGroundMat(PlayerPrefs.GetInt("SceneryNum"));
        ground.transform.localScale = sceneryManager.getGroundSize(PlayerPrefs.GetInt("SceneryNum"));
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
        flappy.transform.position = new Vector2(flappy.transform.position.x, 1.17f);
        flappy.transform.localScale = new Vector3(9,9,1);
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
        endB.SetActive(true);
    }

    
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
    public void gameOver()
    {
        if (score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
            newHigh.SetActive(true);
        }
        boardScore.text = score.ToString();
        boardHigh.text = PlayerPrefs.GetInt("HighScore").ToString();
        gameOvers.SetActive(true);
        gameplay.SetActive(false);
        scoreTx.SetActive(false );
        if (score >= 10)
        {
            Medal.SetActive(true );    
        }

        if (score >= 10&&score<20)
        {
            medal.overrideSprite = bronze;
            medal.rectTransform.sizeDelta = new Vector2(383.4f, 341.6f);
        }
        else if (score >= 20 && score < 30)
        {
            medal.overrideSprite = silver;
            medal.rectTransform.sizeDelta = new Vector2(359.3f, 317.1f);
        }
        else if (score >= 1 && score < 40)
        {
            medal.overrideSprite = gold;
            medal.rectTransform.sizeDelta = new Vector2(366.1f, 326.1f);
        }
        else if (score > 40)
        {
            medal.overrideSprite = plat;
            medal.rectTransform.sizeDelta = new Vector2(350.9f, 338.5f);
        }
    }
}
