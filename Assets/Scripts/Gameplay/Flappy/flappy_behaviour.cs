using System.Collections;
using System.Collections.Generic;
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
    public bool fly;
    public Sprite flappy;
    public AudioSource flap,die,swoosh;
    public bool flappy_Alive;

    // Start is called before the first frame update
    void Start()
    {
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
        flappy_Alive =true;
        flappy_rigid.gravityScale = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         if (flappy_Alive&&fly)
        {
               
            if (flappy_rigid.gravityScale == 0)
            {
                flappy_rigid.gravityScale = 4.5f;
            }

            flap.Play();
            
            Animator.SetBool("fall", false);

            flappy_rigid.velocity = (Vector2.up * flap_strength) * Time.fixedDeltaTime;

             if (flappy_render.transform.rotation.z != 20f)
            {
                Animator.SetBool("up",true);
            }
            fly = false;
        }
        if (flappy_rigid.velocity.y < -21)
        {
            swoosh.Play();
            Animator.SetBool("up", false);
            Animator.SetBool("fall", true);
        }
            
        if (transform.position.y < -15)
        {
            flappy_Alive = false;
            die.Play();
            logic_script.gameOver();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        die.Play();
        flappy_Alive=false;
        logic_script.gameOver();
        Time.timeScale = 0;
    }
    public void flying()
    {
        fly=true;
    }
}
