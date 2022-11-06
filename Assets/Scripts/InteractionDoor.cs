using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionDoor : MonoBehaviour
{
    float distance = 1.5f;

    public GameObject TextDetect;
    GameObject lastRecognized = null;

    LayerMask mask;

    void Start()
    {
        mask = LayerMask.GetMask("Raycast Detect Puerta");
        TextDetect.SetActive(false);
    }
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, distance, mask))
        {
            Deselect();
            SelectObject(hit.transform);
            if (hit.collider.tag == "Puerta")
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    hit.collider.transform.GetComponent<DoorBehaviour>().ChangeDoorState();
                }
            }
        }
        else
        {
            Deselect();
        }

    }

    void SelectObject(Transform transform)
    {
        transform.GetComponent<MeshRenderer>().material.color = Color.red;
        lastRecognized = transform.gameObject;
    }

    void Deselect()
    {
        if (lastRecognized)
        {
            lastRecognized.GetComponent<Renderer>().material.color = Color.white;
            lastRecognized = null;
        }
    }

    private void OnGUI()
    {
        if (lastRecognized)
        {
            TextDetect.SetActive(true);
        }
        else
        {
            TextDetect.SetActive(false);
        }
    }
}