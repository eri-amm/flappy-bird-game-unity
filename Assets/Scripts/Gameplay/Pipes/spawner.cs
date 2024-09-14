using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    public GameObject pipe;
    public float spawn_rate=2;
    public flappy_behaviour status;
    public float timer = 0;
    public float highest = 5.0f;
    public float lowest = -2.5f;
    void spawn()
    {
        
        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowest,highest),0), transform.rotation);
        
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
