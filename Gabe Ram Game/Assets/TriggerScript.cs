using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{

    
     public GameObject physicalRam;
     public GameManager gameManager;


     void OnTriggerEnter(Collider collision)
    {

        if (collision.tag == "Ram")
        {

            gameManager.ramCount++;
            Destroy(physicalRam);
            
            

        }


    }


}
