using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Disinfectant : MonoBehaviour
{
    public GameObject SpawnItem;  //Choose what to spawn
    [SerializeField] Vector3 spawnPos = new Vector3(0, 1, -7); //where to spawn
    
    //[SerializeField] string strTag; // Choose what needs to collide with


    private float startDelay = 0.1f;
    private float repeatRate = 0.1f;


    //private void OnCollisionEnter(Collision collision)
    private void OnTriggerEnter(Collider other)
    //
    {

        //if (Input.GetKey(KeyCode.Space))
        //if (collision.collider.tag == strTag)
        //if (other.gameObject.tag == "Player")
        {
            //Instantiate(SpawnItem, spawnPos, SpawnItem.transform.rotation);
            Invoke("SpawnWater", 0.1f);
            //Destroy(SpawnItem, 5);

           //Invoke("DestroyObjectDelayed", 0.1f);
            //InvokeRepeating("SpawnWater", startDelay, repeatRate);


        }

        





    }
    void DestroyObjectDelayed()
    {
        // Kills the game object in 5 seconds after loading the object
        Destroy(SpawnItem, 5);
    }
    void SpawnWater()
    {
        int numParticles = 10;

        for (int i = 0; i < numParticles; i++)
       {
           Instantiate(SpawnItem, spawnPos, SpawnItem.transform.rotation);
           i++;
           
        }

    }
}