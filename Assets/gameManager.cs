using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public static gameManager miGM;
    public int puntos;
    public int vida;
    // Start is called before the first frame update
    void Start()
    {
        miGM=this;
        vida = 10;
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
