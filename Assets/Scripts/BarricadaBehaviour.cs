using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarricadaBehaviour : MonoBehaviour
{
    float velocidad = 1f;

    public void Update()
    {
        transform.Translate(0, velocidad * Time.deltaTime, 0);
        if (transform.position.y > 0f || transform.position.y < -6f)
        {
            velocidad *= -1;
        }
    }
}
