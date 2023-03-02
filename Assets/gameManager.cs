using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public static gameManager instance;
    public int puntos;
    // Start is called before the first frame update
    void Start()
    {
        instance= this;
    }

    public void SumarPuntos()
    {
        puntos++;     
    }
}
