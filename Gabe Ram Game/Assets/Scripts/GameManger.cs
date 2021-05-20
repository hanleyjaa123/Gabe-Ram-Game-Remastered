using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int ramCount;



    void GameOver()
    {

        Debug.Log("game over");

    }



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (ramCount >= 2)
        {

            GameOver();

        }


    }
}
