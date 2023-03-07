using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{

    public enum estadosGame
    {
        Menu,
        Juego,
        Pausa,
    }

    public estadosGame estadoActual;



    public static gameManager miGM;
    public int puntos;
    public int vida;
    // Start is called before the first frame update
    void Start()
    {
        miGM=this;
        vida = 10;
    }

    void Update()
    {

        switch (estadoActual)
        {
            case estadosGame.Menu:
                Debug.Log("Estado: Menu");
                break;
            case estadosGame.Juego:                
                Debug.Log("Estado: Juego");
                break;
            case estadosGame.Pausa: 
                Debug.Log("Estado: Pausa");
                break;
        }


    }

    public void SumarPuntos()
    {
        puntos++;     
    }

    public void damage()
    {
        vida--;
    }
}
