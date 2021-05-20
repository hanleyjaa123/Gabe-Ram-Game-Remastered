using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{

    
     // public GameObject physicalRam;
     public GameManager gameManager;


     void OnTriggerEnter(Collider collision)
    {

        if (collision.tag == "Ram")
        {

            gameManager.ramCount++;

            // multi objects that need to be destroyed, i tried using this but it destroys whatever object with tag ram comes first in hierarchy 
            Destroy(GameObject.FindWithTag("Ram"));
            
            

        }


    }


}
