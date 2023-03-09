using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movSimple : MonoBehaviour
{
    Rigidbody2D rbplayer;
    public float movX,movY,speed,jumpS;

    void Start()
    {
        rbplayer=GetComponent<Rigidbody2D>();
    }

    // El Update se ejecuta cada frame
    void Update()
    {
        movX=Input.GetAxis("Horizontal")*speed;
        //movY=Input.GetAxis("Vertical")*speed; //Ahorita no tenemos movimiento vertical

        if (Input.GetButtonDown("Jump"))
        {
            rbplayer.AddForce(Vector2.up*jumpS);
        }
    }

    //El FixedUpdate se ejecuta cada cierto tiempo en fracciones de segundo (El tiempo entre un frame y otro)
    void FixedUpdate()
    {
        rbplayer.velocity = new Vector2(movX, rbplayer.velocity.y);
    }
}
