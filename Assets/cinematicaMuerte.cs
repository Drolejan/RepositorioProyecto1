using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;


public class cinematicaMuerte : MonoBehaviour
{
    public PlayableDirector cinematica;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        cinematica.Play();//Reproduce cinematica
    }
}
