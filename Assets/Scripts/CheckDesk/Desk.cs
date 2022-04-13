using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desk : MonoBehaviour
{
    //desk collider is the collider that detects which item is placed on the desk. 
    public Collider deskCollider;
    //these are materials that are used for the indicator. if the answer is correct material changes to rightMat and if it's wrong it changes to wrongMat.
    //basicMat is the normal material of the desk. Return to this material after a while
    public Material rightMat, wrongMat, basicMat;
    //indicator is the desk component that changes color. 
    public GameObject indicator;
    //this can be used to set the time how long it takes for the indicator to turn back into the normal material
    public int waitTime = 5;


    //keeping it simple: checks if the tag is set to correct one and changes material to correct one. After both it starts the MatCountDown coroutine
    //which waits for set amount of time (waitTime) until it changes the material back to basic. 
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Correct")
        {
            indicator.GetComponent<MeshRenderer>().material = rightMat;
            StartCoroutine(MatCountDown(waitTime));
        }
        if(other.tag == "Wrong")
        {
            indicator.GetComponent<MeshRenderer>().material = wrongMat;
            StartCoroutine(MatCountDown(waitTime));
        }
    }
    private void ChangeMaterialBack()
    {
        indicator.GetComponent<MeshRenderer>().material = basicMat;
    }
    
    private IEnumerator MatCountDown(int seconds)
    {
        int counter = seconds;
        {
            while (counter > 0)
            {
                yield return new WaitForSeconds(1);
                counter--;
            }
            ChangeMaterialBack();
        }
    }
    
    
}