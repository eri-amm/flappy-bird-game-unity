using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_behaviour : MonoBehaviour
{
    public float moving_speed = 14.3f;
    public GameObject pipe;
    public bool changedSpeed = false;
    int lastTriggerScore = 0;
    int buckets;
    int timesSpedUp = 0;

    // Update is called once per frame
    void Update()
    {
        buckets = logics.score / 10;

        while (buckets > timesSpedUp)
        {
            timesSpedUp++;           
            moving_speed += 1.5f;      
        }

        transform.position = transform.position + (Vector3.left * moving_speed)*Time.deltaTime;
        
        if (transform.position.x < -33.4f)
        {
            Destroy(gameObject);
        }
    }
}
