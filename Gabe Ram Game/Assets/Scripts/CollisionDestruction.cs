using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDestruction : MonoBehaviour
{

    public GameObject Ram;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        


    }


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(Ram);
        }
    }
}
