using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarNotas : MonoBehaviour
{
    public int numeroNota;

    public GameObject MostrarNota1;
    public GameObject MostrarNota2;
    public GameObject MostrarNota3;
    public GameObject MostrarNota4;
    public GameObject MostrarNota5;
    public GameObject MostrarNota6;
    public GameObject MostrarNota7;
    public GameObject MostrarNota8;

    public void MostrarNota()
    {
        switch (numeroNota)
        {
            case 1:
                MostrarNota1.gameObject.SetActive(true);
                break;
            case 2:
                //if (this.CompareTag("MostrarNota2"))
               // {
                MostrarNota2.gameObject.SetActive(true);
                //}
                break;
            case 3:
                MostrarNota3.gameObject.SetActive(true);
                break;
            case 4:
                MostrarNota4.gameObject.SetActive(true);
                break;
            case 5:
                MostrarNota5.gameObject.SetActive(true);
                break;
            case 6:
                MostrarNota6.gameObject.SetActive(true);
                break;
            case 7:
                MostrarNota7.gameObject.SetActive(true);
                break;
            case 8:
                MostrarNota8.gameObject.SetActive(true);
                break;
        }

    }

    public void DejarNota()
    {
        switch (numeroNota)
        {
            case 1:
                //if (GameObject.FindWithTag("MostrarNota"))
                //{
                MostrarNota1.gameObject.SetActive(false);
                //}
                break;
            case 2:
                MostrarNota2.gameObject.SetActive(false);
                break;
            case 3:
                MostrarNota3.gameObject.SetActive(false);
                break;
            case 4:
                MostrarNota4.gameObject.SetActive(false);
                break;
            case 5:
                MostrarNota5.gameObject.SetActive(false);
                break;
            case 6:
                MostrarNota6.gameObject.SetActive(false);
                break;
            case 7:
                MostrarNota7.gameObject.SetActive(false);
                break;
            case 8:
                MostrarNota8.gameObject.SetActive(false);
                break;
        }

    }

}
