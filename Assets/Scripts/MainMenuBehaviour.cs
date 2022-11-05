using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuBehaviour : MonoBehaviour
{

    public AudioSource click;
    public AudioSource back;
    public AudioSource music;

    public void QuitGame(){
    Debug.Log("Quit");
    Application.Quit();
    }

    public void PlayClick()
    {
    click.Play();
    }
    public void PlayBack()
    {
    back.Play();
    }

    public void PlayStart(){
    music.Stop();    
    }
 
}
