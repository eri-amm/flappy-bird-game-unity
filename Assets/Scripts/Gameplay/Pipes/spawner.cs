using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    public GameObject pipe,spawnedPipe;
    public static float spawn_rate=1.37f;
    public float score = 0;
    public flappy_behaviour status;
    public float lastY=0;
    public float timer = 0;
    public bool changedSpeed = false;
    public float highest = 5.0f;
    public float lowest = -2.5f;
    void spawn()
    {
        spawnedPipe=Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowest,highest)+lastY,0), transform.rotation);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        if (status.flappy_rigid.gravityScale != 0)
        {
            spawn();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if ( (logics.score != 0) && (logics.score % 10 == 0) && (spawn_rate > 0.5f) && !changedSpeed && logics.score<100) 
        {
            spawn_rate -= 0.06f;
            changedSpeed = true;
        }
        if (logics.score % 10 != 0)
        {
            changedSpeed = false;
        }

        lastY = spawnedPipe.transform.position.y;

        if (lastY >= 1)
        {
            lastY = Random.Range(-4,-3);
        }
        else if (lastY<1)
        {
            lastY = Random.Range(4.7f,5.5f);
        }


        if (status.flappy_rigid.gravityScale != 0)
        {
            if (timer < spawn_rate)
                timer = timer + Time.deltaTime;

            else
            {
                spawn();
                timer = 0;
            }
        }
        
    }
}
