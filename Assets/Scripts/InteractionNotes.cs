using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionNotes : MonoBehaviour
{
    LayerMask mask;
    float distance = 3f;

    public GameObject TextDetect;
    GameObject lastRecognized = null;

    void Start()
    {
        mask = LayerMask.GetMask("Raycast Detect Nota");
        TextDetect.SetActive(false);  
    }

    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, distance, mask)) 
        {
            Deselect();
            SelectObject(hit.transform);
            if(hit.collider.tag == "InteraccionNota")
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    hit.collider.transform.GetComponent<MostrarNotas>().MostrarNota();                
                }
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<MostrarNotas>().DejarNota();
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
        transform.GetComponent<MeshRenderer>().material.color = Color.yellow;
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
