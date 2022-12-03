using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePass : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Pass"))
        {

            VictoryMan.victoryMan.CallVictory();
        
            SceneManager.LoadScene("Menu");
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;



        }
    }
}
