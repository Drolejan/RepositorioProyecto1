using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlPersonaje : MonoBehaviour
{
    public GameObject bala;
    public Transform spawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void disparo()
    {
        GameObject flecha=Instantiate(bala,spawn.position,Quaternion.identity);
        Rigidbody2D bodyFlecha=flecha.GetComponent<Rigidbody2D>();
        bodyFlecha.AddForce(Vector2.right * -5f, ForceMode2D.Impulse);
    }

    void granada()
    {

    }
}
