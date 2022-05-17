using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerfursorScript : MonoBehaviour
{
    public static PerfursorScript singleton;
    public GameObject attachPoint;
    public GameObject attachedItem;
    public bool perfursorAttached = false;
    public bool syringeAttached = false;

    private void Awake()
    {
        singleton = this;
    }
    private void OnCollisionEnter(Collision other)
    {
         if(other.gameObject.tag == "Perfursor")
        {
            perfursorAttached = true;
            Destroy(other.gameObject);
            var newPerfursor = Instantiate(attachedItem, attachPoint.transform.position, attachPoint.transform.rotation);
            newPerfursor.transform.parent = attachPoint.transform;

            //other.gameObject.transform.position = attachPoint.transform.position;
        }
        if(other.gameObject.tag == "Syringe")
        {
            syringeAttached = true;
            Destroy(other.gameObject);
            var newSyringe = Instantiate(attachedItem, attachPoint.transform.position, attachPoint.transform.rotation);
            newSyringe.transform.parent = attachPoint.transform;
        }   
    }
}
