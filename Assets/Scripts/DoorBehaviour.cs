using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehaviour : MonoBehaviour
{
    // verfica si la puerta est� abierta o cerrada
    public bool doorOpen = false;

    //�ngulo de la puerta al estar abierta
    float doorOpenAngle = -95f;

    //�ngulo de la puerta al estar cerrada
    float doorCloseAngle = 0.0f;

    //Velocidad de rotaci�n de la puerta
    float velocity = 3.0f;

    public AudioSource door;



    public void ChangeDoorState()
    {
        doorOpen = !doorOpen;
        door.Play();
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
