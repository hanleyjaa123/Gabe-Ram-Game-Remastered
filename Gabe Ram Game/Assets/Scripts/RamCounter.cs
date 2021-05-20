using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RamCounter : MonoBehaviour
{

    public gameManager gameManager;
    
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Ram Collected: " + gameManager.ramCount.ToString();





    }
}
