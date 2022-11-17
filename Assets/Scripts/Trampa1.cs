using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampa1 : MonoBehaviour
{
    [SerializeField]
    private float speedY = 5f;

    private void Update()
    {
        MoverProyectil();
        if (this.transform.position.y >= 7f)
        {
            Destroy(gameObject);

        }

    }


    public void MoverProyectil()
    {
        transform.Translate(0,speedY * Time.deltaTime, 0);
    }

}
