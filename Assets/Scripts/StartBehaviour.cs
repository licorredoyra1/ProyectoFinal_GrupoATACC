using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartBehaviour : MonoBehaviour
{

    public AudioSource start;
    // Start is called before the first frame update
    void Start()
    {
       if (SceneManager.GetActiveScene().buildIndex == 1){
        start.Play();
       }
    }

  
}
