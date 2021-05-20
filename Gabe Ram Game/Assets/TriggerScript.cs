using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{

    
     public GameObject physicalRam;
    public RamCounter ramCounter;


     void OnTriggerEnter(Collider collision)
    {

        if (collision.tag == "Ram")
        {

            ramCounter.ramCount++;
            Destroy(physicalRam);
            
            

        }


    }


}
