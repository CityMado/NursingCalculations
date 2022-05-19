using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desk : MonoBehaviour
{
    public enum SubObjective {Syringe, Medicine}
    public SubObjective subObjective;
    public static Desk singleton;
    //desk collider is the collider that detects which item is placed on the desk. 
    public Collider deskCollider;
    //these are materials that are used for the indicator. if the answer is correct material changes to rightMat and if it's wrong it changes to wrongMat.
    //basicMat is the normal material of the desk. Return to this material after a while
    public Material rightMat, wrongMat, basicMat;
    //indicator is the desk component that changes color. 
    public GameObject indicator, collidedObject;
    //this can be used to set the time how long it takes for the indicator to turn back into the normal material
    public int waitTime = 5;
    // Ampulle GameObject
    public GameObject Ampulle, towel;
    public bool correctMedicine, wrongMedicine, correctSyringe, wrongSyringe;
    
    private void Awake()
    {
        singleton = this;
    }
    private void Start()
    {
        collidedObject = null;
        
        //ampulle isnot active when the game starts // add the object in the unity
        Ampulle.SetActive(false);
        towel.SetActive(false);
    }
    //keeping it simple: checks if the tag is set to correct one and changes material to correct one. After both it starts the MatCountDown coroutine
    //which waits for set amount of time (waitTime) until it changes the material back to basic. 
    private void OnTriggerEnter(Collider other)
    {
        
        switch(subObjective)
        {
            case SubObjective.Medicine:
                if(other.tag == "Correct")
                    {
                     indicator.GetComponent<MeshRenderer>().material = rightMat;
                     StartCoroutine(MatCountDown(waitTime));
                     correctMedicine = true;
                     wrongMedicine = false;
                    }
                if(other.tag == "Wrong")
                    {
                     indicator.GetComponent<MeshRenderer>().material = wrongMat;
                     collidedObject = other.gameObject;
                     StartCoroutine(MatCountDown(waitTime));
                     correctMedicine = false;
                     wrongMedicine = true;
                    }
            break;
            case SubObjective.Syringe:
            {
                if(other.tag == "SyringeSmall")
                {
                    indicator.GetComponent<MeshRenderer>().material = rightMat;
                    StartCoroutine(MatCountDown(waitTime));
                    correctSyringe = true;
                    wrongSyringe = false;
                }
                if(other.tag == "Wrong")
                {
                    indicator.GetComponent<MeshRenderer>().material = wrongMat;
                    collidedObject = other.gameObject;
                    StartCoroutine(MatCountDown(waitTime));
                    correctSyringe = false;
                    wrongSyringe = true;
                }
            }
            break;
        }

        if(other.tag == "Correct")
        {
            indicator.GetComponent<MeshRenderer>().material = rightMat;
            StartCoroutine(MatCountDown(waitTime));
            correctMedicine = true;
            wrongMedicine = false;
        }
        if(other.tag == "Wrong")
        {
            indicator.GetComponent<MeshRenderer>().material = wrongMat;
            collidedObject = other.gameObject;
            StartCoroutine(MatCountDown(waitTime));
            correctMedicine = false;
            wrongMedicine = true;
        }
    }
    private void ChangeMaterialBack()
    {
        indicator.GetComponent<MeshRenderer>().material = basicMat;
        if(collidedObject != null)
        {
            Destroy(collidedObject);
        }
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
