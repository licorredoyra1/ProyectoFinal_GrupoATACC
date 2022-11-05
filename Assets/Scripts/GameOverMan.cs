using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverMan : MonoBehaviour
{
    public GameObject GameOver;
    public static GameOverMan gameOverMan;
    // Start is called before the first frame update
    void Start()
    {
        gameOverMan = this;
        GameOver.SetActive(false);
    }

    // Update is called once per frame
     public void CallGameOver()
    {
        GameOver.SetActive(true);
    }

    public void UnCallGameOver()
    {
        GameOver.SetActive(false);
    }
}
