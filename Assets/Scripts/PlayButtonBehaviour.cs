using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayButtonBehaviour : MonoBehaviour
{

    //public GameObject LevelLoader;

    // Update is called once per frame
    public Animator transition;
    void Update()
    {
        if (Input.GetKeyDown("enter")) 
        {
            //transition.SetTrigger("Start");

            SceneManager.LoadScene("Mapa Juego final");

        }
    }
}
