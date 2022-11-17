using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorTrampa02 : MonoBehaviour
{
    [SerializeField]
    private GameObject pinchos;
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
        endTime = 0.2f;
        InvokeRepeating("GeneratePinchos", initTime, endTime);
    }
    public void GeneratePinchos()
    {
        Instantiate(pinchos, transform.position, transform.rotation);


    }
    public void Update()
    {

        if (transform.position.x >= 13f || transform.position.x <= 6f)
        {
            speedX *= -1;
        }
        transform.Translate(speedX * Time.deltaTime, 0, 0);

    }
}
