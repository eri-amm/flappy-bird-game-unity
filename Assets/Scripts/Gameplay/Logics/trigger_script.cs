using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_script : MonoBehaviour
{

    public logics logic_script;
    
    // Start is called before the first frame update
    void Start()
    {
        logic_script = GameObject.FindGameObjectWithTag("logic").GetComponent<logics>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer==3)
        {
            logic_script.inc_scr();
        }
    }
}
