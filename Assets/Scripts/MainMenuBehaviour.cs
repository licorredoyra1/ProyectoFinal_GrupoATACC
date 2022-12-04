using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuBehaviour : MonoBehaviour
{

    public AudioSource click;
    public AudioSource back;
    public AudioSource music;
    public AudioSource scroll;

    public void QuitGame(){
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
    public void PlayScroll() {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow)) {
            scroll.Play();
        
        }
    
    
    }
}
