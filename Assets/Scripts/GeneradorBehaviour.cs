using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorBehaviour : MonoBehaviour
{

    public GameObject Enemigo;

    [SerializeField]
    private float initTime;
    [SerializeField]
    private float endTime;

    private int positionNumber;

    // Start is called before the first frame update
    void Start()
    {
        initTime = 0f;
        endTime = 15f;
        InvokeRepeating("Generate", initTime, endTime);


    }

    public void Generate()
    {


        positionNumber = Random.Range(0, 3);
        this.Spawn();


    }

    void Spawn() {

        switch (positionNumber)
        {
            case 0:
                this.transform.position = new Vector3(53, 2, -99);
                Instantiate(Enemigo, this.transform.position, Quaternion.identity);
                break;
            case 1:
                this.transform.position = new Vector3(2, 1, -102);
                Instantiate(Enemigo, this.transform.position, Quaternion.identity);
                break;

            case 2:
                this.transform.position = new Vector3(145, 2, -101);
                Instantiate(Enemigo, this.transform.position, Quaternion.identity);
                break;

            case 3:
                this.transform.position = new Vector3(142, 2, -252);
                Instantiate(Enemigo, this.transform.position, Quaternion.identity);
                break;



        }
    }
}
