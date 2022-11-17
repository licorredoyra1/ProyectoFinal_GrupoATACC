using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorTrampa : MonoBehaviour
{
    
    [SerializeField]
    private GameObject proyectil;
    [SerializeField]
    private float initTime;
    [SerializeField]
    private float endTime;
    [SerializeField]
    private float speedX = -20f;

    // Start is called before the first frame update
    void Start()
    {
        initTime = 0;
        endTime = 0.5f;
        InvokeRepeating("GenerateProyectiles", initTime, endTime);
    }
    public void GenerateProyectiles()
    {
        Instantiate(proyectil, transform.position, transform.rotation);


    }
    public void Update()
    {

        if (transform.position.x < 24f || transform.position.x > 32f)
        {
            speedX *= -1;
        }
        transform.Translate(speedX * Time.deltaTime,0, 0);

    }
}

