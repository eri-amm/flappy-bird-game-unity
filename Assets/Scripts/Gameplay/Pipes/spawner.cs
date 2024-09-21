using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    public GameObject pipe,spawnedPipe;
    public float spawn_rate=5;
    public flappy_behaviour status;
    public float lastY=0;
    public float timer = 0;
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
