using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoEnemigo : MonoBehaviour
{
    [SerializeField]
    public AudioSource grunido;
    [SerializeField]
    public AudioSource arrastre;
 
  

    void Update()
    {
        if (Input.GetKey("f"))
        {
            grunido.Play();
        }
        if (Input.GetKey("space"))
        {
            grunido.Play();
        }
        if (Input.GetKey("e"))
        {
            grunido.Play();
     
        }
        arrastre.Play();
    }
}
