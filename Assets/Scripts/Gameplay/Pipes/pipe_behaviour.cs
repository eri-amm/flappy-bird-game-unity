using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_behaviour : MonoBehaviour
{
    public float moving_speed;
    public GameObject pipe;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moving_speed)*Time.deltaTime;
        
        if (transform.position.x < -33.4f)
        {
            Destroy(gameObject);
        }
    }
}
