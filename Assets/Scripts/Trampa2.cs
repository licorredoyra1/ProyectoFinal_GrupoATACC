using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampa2 : MonoBehaviour
{
    [SerializeField]
    private float speedY = 3f;

    private void Update()
    {
        MoverBarril();
        if ( transform.position.y >= 0.1f)
        {
            speedY *= -1;
        }
        if (transform.position.y <= -2f || transform.position.y >= 0.3f)
        {
            Destroy(gameObject);

        }

    }


    public void MoverBarril()
    {
        transform.Translate(0, speedY * Time.deltaTime, 0);
    }

}