using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionNotes : MonoBehaviour
{
    LayerMask mask;
    float distance = 10f;

    public GameObject TextDetect;
    GameObject lastRecognized = null;

    public GameObject MostrarNota;


    void Start()
    {
       // MostrarNota.gameObject.SetActive(false);

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
                    //Destroy(GameObject.Find("InteraccionNota"));
                    MostrarNota.gameObject.SetActive(true);
                }
            }
        }
        else 
        {
            Deselect();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            MostrarNota.gameObject.SetActive(false);
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
