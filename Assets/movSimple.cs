using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movSimple : MonoBehaviour
{
    Rigidbody2D rbplayer;
    public float movX,movY,speed,jumpS;

    // Start is called before the first frame update
    void Start()
    {
        rbplayer=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movX=Input.GetAxis("Horizontal")*speed;
        //movY=Input.GetAxis("Vertical")*speed;

        rbplayer.velocity= new Vector2(movX,rbplayer.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            rbplayer.AddForce(Vector2.up*jumpS);
        }
    }
}
