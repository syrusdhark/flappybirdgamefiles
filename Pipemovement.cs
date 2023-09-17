using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Pipemovement : MonoBehaviour
{
    public float movespeed=3000;
    public float deadzone = -40;
    public Logicscript SCORE;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * movespeed) * Time.deltaTime * 20;
        if (transform.position.x < deadzone)
        {
            Destroy(gameObject);
        }

        
    }

    

       
}
