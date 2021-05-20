using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonActions : MonoBehaviour
{


    public void Quit ()
    {

        Application.Quit();

    }

    public void StartGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }


}
