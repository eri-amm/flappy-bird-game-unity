using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class flappy_behaviour : MonoBehaviour
{
    public SpriteRenderer flappy_render;
    public Rigidbody2D flappy_rigid;
    public float flap_strength;
    public logics logic_script;
    public Animator Animator;
    public Sprite down,up,mid;
    public AudioSource flap,die,swoosh;
    public bool fall;
    public double timer = 0;
    public bool flappy_Alive;
    
    // Start is called before the first frame update
    void Start()
    {
        
        logic_script = GameObject.FindGameObjectWithTag("logic").GetComponent<logics>();
        flappy_Alive=true;
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space)||(Input.touchCount==1))&&(flappy_Alive))
         {
            flap.Play();
            Animator.SetBool("fall", false);
            flappy_rigid.velocity = Vector2.up * flap_strength;
             if (flappy_render.transform.rotation.z != 20f)
            {
                Animator.SetBool("up",true);
            }
            
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
        flappy_render.sprite = down;
        Time.timeScale = 0;
    }
}
