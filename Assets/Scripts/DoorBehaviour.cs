using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehaviour : MonoBehaviour
{
    // verfica si la puerta está abierta o cerrada
    public bool doorOpen = false;

    //Ángulo de la puerta al estar abierta
    float doorOpenAngle = -95f;

    //Ángulo de la puerta al estar cerrada
    float doorCloseAngle = 0.0f;

    //Velocidad de rotación de la puerta
    float velocity = 3.0f;



    public void ChangeDoorState()
    {
        doorOpen = !doorOpen;
    }

    void Update()
    {
        if (doorOpen)
        {
            Quaternion targetRotation = Quaternion.Euler(0, doorOpenAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, velocity * Time.deltaTime);

        }
        else
        {
            Quaternion targetRotation2 = Quaternion.Euler(0, doorCloseAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation2, velocity * Time.deltaTime);
        }
    }
}
