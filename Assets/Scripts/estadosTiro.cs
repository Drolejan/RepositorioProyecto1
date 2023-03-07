using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class estadosTiro : MonoBehaviour
{
    public enum estados
    {
        Neutral,
        Apuntando,
        Cargando,
        Disparando,
    }
    //public string estado = "Neutral";
    public estados estado;
    public float dir,force;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        estado = estados.Neutral;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (estado)
        {
            case estados.Neutral:
                Debug.Log("Listo para disparar");
                enReposo();
                break;
            case estados.Apuntando:
                Debug.Log("Apuntando");
                apuntando();
                break;
            case estados.Cargando:
                Debug.Log("Cargando");
                cargando(); 
                break;
            case estados.Disparando:
                Debug.Log("Disparando");
                disparando();
                break;
            default:
                Debug.Log("Esto no debería suceder");
                break;
        }
    }

    public void enReposo()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            estado = estados.Apuntando;
        }
    }

    public void apuntando()
    {
        dir++;
        if (dir > 360)
        {
            dir = 0;
        }
        if (Input.GetButtonDown("Fire1"))
        {
            estado = estados.Cargando;
        }
    }

    public void cargando()
    {
        force += 10;
        if (force > 1000)
        {
            force = 0;
        }
        if (Input.GetButtonDown("Fire1"))
        {
            estado = estados.Disparando;
        }
    }

    public void disparando()
    {
        rb.AddForce(Vector3.up * force);
        estado = estados.Neutral;
    }
}
