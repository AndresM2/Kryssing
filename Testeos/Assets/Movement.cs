using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            player.transform.Translate(0,0,-1*Time.deltaTime);
        }
    }
}
