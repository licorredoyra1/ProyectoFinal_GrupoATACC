using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RadioMuerte : MonoBehaviour
{
    //public AudioSource death;
    public Transform respawn;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //death.Play();
            SceneManager.LoadScene("Mapa Juego final");
            other.transform.position = respawn.position;
            //GameOverMan.gameOverMan.CallGameOver();

        }

    }
}
