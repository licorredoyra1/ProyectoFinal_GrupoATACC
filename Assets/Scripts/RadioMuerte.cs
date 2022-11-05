using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioMuerte : MonoBehaviour
{
    public Transform respawn;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.position = respawn.position;
            GameOverMan.gameOverMan.CallGameOver();

        }

    }
}
