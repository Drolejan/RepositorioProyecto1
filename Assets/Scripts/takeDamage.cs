using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeDamage : MonoBehaviour
{
    public SpriteRenderer spritePersonaje;
    public bool cooldown;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemigo") && !cooldown)
        {
            //Aqui empieza la corutina del daño
            StartCoroutine(golpeado());
        }
    }

    IEnumerator golpeado()
    {
        gameManager.miGM.damage();
        Color colorOriginal = spritePersonaje.color;
        spritePersonaje.color = new Color(1,1,1,0.5f);
        cooldown = true;
        yield return new WaitForSeconds(3);
        spritePersonaje.color = colorOriginal;
        cooldown = false;
    }

}
