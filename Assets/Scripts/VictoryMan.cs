using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryMan : MonoBehaviour
{
 
    public GameObject Victory;
    public static VictoryMan victoryMan;
    // Start is called before the first frame update
    void Start()
    {
        victoryMan = this;
        Victory.SetActive(false);
    }

    // Update is called once per frame
    public void CallVictory()
    {
        Victory.SetActive(true);
    }

    public void UnCallVictory()
    {
       Victory.SetActive(false);
    }
}

