using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class disparo : MonoBehaviour
{
    public GameObject bala;
    public Transform spawn;
    [SerializeField] float vel;

    void midisparo()
    {
        GameObject flecha = Instantiate(bala, spawn.position, Quaternion.identity);
        Destroy(flecha,3f);
        Rigidbody2D bodyFlecha = flecha.GetComponent<Rigidbody2D>();
        bodyFlecha.AddForce((transform.right * vel) * -spawn.localScale.x , ForceMode2D.Impulse);
    }

}
