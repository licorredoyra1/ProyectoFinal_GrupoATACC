using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaAyuda : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Puerta1;
    public GameObject PuertaCerrada;
    // Start is called before the first frame update
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ObjMov"))
            if (Input.GetMouseButtonDown(0))
            {
                Puerta1.transform.position = PuertaCerrada.transform.position;

            }
    }
}
