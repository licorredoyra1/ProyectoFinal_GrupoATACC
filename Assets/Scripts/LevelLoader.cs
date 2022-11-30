using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{



    public Animator transition;

    public float transitionTime = 1f;

    public void PlayGame()
    {
        SceneManager.LoadScene("Mapa Juego final");


        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }


    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(levelIndex);

    }
}
