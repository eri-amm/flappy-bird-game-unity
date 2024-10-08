using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class flappy_behaviour : MonoBehaviour
{
    public SpriteRenderer flappy_render;
    public Rigidbody2D flappy_rigid;
    public logics status;
    public float flap_strength;
    public logics logic_script;
    public Animator Animator;
    public bool isStill;
    public GameObject readyIMG,flappyObj;
    public bool isFlying;
    public Sprite flappy,bluedeath;
    public AudioSource flap,die,swoosh;
    public bool isAlive;

    void Start()
    {
        isStill=true;
        flappy_rigid.gravityScale = 0;
        if (PlayerPrefs.GetInt("SkinNum") == 0)
        {
            Animator.Play("Gold_fly");
            Animator.Update(0);
        }
        else if (PlayerPrefs.GetInt("SkinNum") == 2)
        {
            Animator.Play("Red_fly");
            Animator.Update(0);
        }
        else if(PlayerPrefs.GetInt("SkinNum") == 1)
        {
            Animator.Play("Sky_fly");
            Animator.Update(0);
        }
        logic_script = GameObject.FindGameObjectWithTag("logic").GetComponent<logics>();
        flap.volume = PlayerPrefs.GetInt("FlappyVol");
        die.volume = PlayerPrefs.GetInt("FlappyVol");
        swoosh.volume = PlayerPrefs.GetInt("FlappyVol");
        isAlive =true;
        flappy_rigid.gravityScale = 0;
    }

    void FixedUpdate()
    {
        if (isAlive&&isFlying)
        {
               
           if (flappy_rigid.gravityScale == 0)
           {
              flappy_rigid.gravityScale = 9.9f;
           }

           flap.Play();
            
           Animator.SetBool("fall", false);

           flappy_rigid.velocity = (Vector2.up * flap_strength) * Time.fixedDeltaTime;

           if (!Animator.GetBool("up"))
           {
              Animator.SetBool("up",true);
           }
           isFlying = false;
        }
        
        if (flappy_rigid.velocity.y < -28)
        {
            swoosh.Play();
            Animator.SetBool("up", false);
            Animator.SetBool("fall", true);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isAlive = false;
        Time.timeScale = 0;
        die.Play();
        logic_script.gameOver();
    }
    public void flying()
    {
        isFlying=true;
        if (isStill)
        {
            readyIMG.SetActive(false);
            isStill = false;
        }
    }
}
