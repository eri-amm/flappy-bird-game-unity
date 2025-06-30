using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class logics : MonoBehaviour
{
    public static int score=0;
    public bool flashed;
    public sceneryManager sceneryManager;
    public MeshRenderer sky,ground;
    public TextMeshProUGUI scoreT,highScore,boardScore,boardHigh;
    public AudioSource point,die;
    public Button pauseB;
    public Image medal,flashIMG;
    public Sprite pauseS, playS,bronze,silver,gold,plat;
    public GameObject gameOvers,startMenu,countdowntext,gameplay,scoreTx,newHigh,Medal,flappy,endB, jumpB, flash,versionChecker,ostmanager,counter;

    void Start()
    {
        if (!checkUpdate.isUpdated)
        {
            versionChecker.SetActive(true);
            Time.timeScale = 0 ;
            ostmanager.SetActive(false);
        }
        point.volume = PlayerPrefs.GetFloat("PointsVol");
        Application.targetFrameRate = 120;
        flash.SetActive(false);
        if(PlayerPrefs.GetFloat("FlappyVol")>0)
            die.volume = 0.1f;
        highScore.text = Convert.ToString(PlayerPrefs.GetInt("HighScore"));
        sky.material = sceneryManager.GetSkyScenery(PlayerPrefs.GetInt("SceneryNum"));
        sky.transform.localScale = sceneryManager.getSkySize(PlayerPrefs.GetInt("SceneryNum"));
        sky.transform.localPosition = sceneryManager.getSkyPos(PlayerPrefs.GetInt("SceneryNum"));
        ground.material = sceneryManager.getGroundMat(PlayerPrefs.GetInt("SceneryNum"));
        ground.transform.localScale = sceneryManager.getGroundSize(PlayerPrefs.GetInt("SceneryNum"));
    }
    private void Update()
    {
        if (flash.activeSelf)
        {
            if (!flashed)
            {
                flashIMG.color = new Color(1, 1, 1, flashIMG.color.a + (0.099f ) );
                if (flashIMG.color.a > 0.99f)
                {
                    flashed = true;
                    flappy.SetActive(false);
                }
            }
            else
            {
                flashIMG.color = new Color(1, 1, 1, flashIMG.color.a - (0.099f ));
                if (flashIMG.color.a < 0.01f)
                {
                    flash.SetActive(false);
                }
            }
        }
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
        flappy.transform.position = new Vector2(-10.42f, 1.17f);
        flappy.transform.localScale = new Vector3(11.3f,11.8f,1);
    }
    public void pause()
    {
        if (Time.timeScale != 0)
        {
            Time.timeScale = 0;
            pauseB.image.overrideSprite = playS;
            jumpB.SetActive(false);
            endB.SetActive(true);

        }
        else
        {
            StartCoroutine(Countdown());
        }
    }

    IEnumerator Countdown()
    {
        int count = 3;
        counter.SetActive(true);
        while (count > 0)
        {
            countdowntext.GetComponent<TextMeshProUGUI>().SetText((count--).ToString());
            yield return new WaitForSecondsRealtime(1f); 
        }
        counter.SetActive(false);
        Time.timeScale = 1;
        pauseB.image.overrideSprite = pauseS;
        jumpB.SetActive(true);
        endB.SetActive(false);
    }

    public void restart()
    {
        logics.score = 0;
        spawner.spawn_rate = 1.37f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
    public void gameOver()
    {
        flash.SetActive(true);
        die.Play();
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
            Medal.SetActive(true);    
        }

        if (score >= 10 && score < 20) 
        {
            medal.overrideSprite = bronze;
            medal.rectTransform.sizeDelta = new Vector2(336.6f, 287.2f);
        }
        else if (score >= 20 && score < 30)
        {
            medal.overrideSprite = silver;
            medal.rectTransform.sizeDelta = new Vector2(312.4f, 267f);
        }
        else if (score >= 30 && score < 40)
        {
            medal.overrideSprite = gold;
            medal.rectTransform.sizeDelta = new Vector2(322.5f, 271.3f);
        }
        else if (score > 40)
        {
            medal.overrideSprite = plat;
            medal.rectTransform.sizeDelta = new Vector2(298.3f, 271.3f);
        }
    }
}
