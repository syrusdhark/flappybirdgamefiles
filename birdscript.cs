using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D mrigidbody2D;
    public float flapstrength;
    public Logicscript logic;
    public bool birdisalive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<Logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            mrigidbody2D.velocity = Vector2.up * flapstrength;
            FindObjectOfType<AudioManager>().Play("flapsound");                        
        }
        if (Input.touchCount >0)
        {
            Touch T=Input.GetTouch(0);
            mrigidbody2D.velocity = Vector2.up * flapstrength;
            FindObjectOfType<AudioManager>().Play("flapsound");

        }

       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        
        birdisalive = false;
        if(birdisalive == false)
        {
            logic.Gameovermenu();
            flapstrength = 0;
            FindObjectOfType<AudioManager>().Play("game over");

        }
    }
}
