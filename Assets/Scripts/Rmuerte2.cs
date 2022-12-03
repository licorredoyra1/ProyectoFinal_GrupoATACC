using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Rmuerte2 : MonoBehaviour
{
    //public AudioSource death;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //death.Play();
            SceneManager.LoadScene("NIVEL 2");
            //GameOverMan.gameOverMan.CallGameOver();

        }

    }
}

