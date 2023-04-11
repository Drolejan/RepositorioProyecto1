using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movSimple : MonoBehaviour
{
    Rigidbody2D rbplayer;
    public float movX,movY,speed,jumpS,knockback;
    Animator playerAnims;
    bool isHit;

    void Start()
    {
        rbplayer=GetComponent<Rigidbody2D>();
        playerAnims=GetComponent<Animator>();
    }

    // El Update se ejecuta cada frame
    void Update()
    {
        if(!isHit)
        movX=Input.GetAxis("Horizontal")*speed;

        if (Input.GetButtonDown("Jump"))
        {
            rbplayer.AddForce(Vector2.up*jumpS);
        }
        else if (Input.GetButtonDown("Fire1"))
        {
            playerAnims.SetTrigger("tiro");
        }


        if(movX>0)
        {
            transform.localScale= new Vector3(-1, 1, 1);
            playerAnims.SetBool("caminando",true);
        }
        else if(movX<0) 
        {
            transform.localScale = new Vector3(1, 1, 1);
            playerAnims.SetBool("caminando",true);
        }
        else
        {
            playerAnims.SetBool("caminando",false);
        }
    }

    //El FixedUpdate se ejecuta cada cierto tiempo en fracciones de segundo (El tiempo entre un frame y otro)
    void FixedUpdate()
    {
        if(movX!=0 && !isHit)
        {
        rbplayer.velocity = new Vector2(movX, rbplayer.velocity.y);
        }
        else if(movX == 0 && !isHit)
        {
        rbplayer.velocity = new Vector2(0, rbplayer.velocity.y);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemigo"))
        {
            StartCoroutine(golpeado());
        }
    }

    IEnumerator golpeado()
    {
        isHit = true;
        playerAnims.SetTrigger("golpeado");
        if (movX > 0)
        {
            rbplayer.AddForce(new Vector2(-1, 1) * knockback, ForceMode2D.Impulse);
        }
        else
        {
            rbplayer.AddForce(new Vector2(1, 1) * knockback, ForceMode2D.Impulse);
        }
        yield return new WaitForSeconds(1f);
        isHit = false;
    }
}
