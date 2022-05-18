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
    public bool needleFilterAttached = false;

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
        if(other.gameObject.tag == "Needle")
        {
            syringeAttached = true;
            Destroy(other.gameObject);
            var newSyringe = Instantiate(attachedItem, attachPoint.transform.position, attachPoint.transform.rotation);
            newSyringe.transform.parent = attachPoint.transform;
        }  
        if(other.gameObject.tag == "NeedleFilter")
        {
            needleFilterAttached = true;
            Destroy(other.gameObject);
            var newFilter = Instantiate(attachedItem, attachPoint.transform.position, attachPoint.transform.rotation);
            newFilter.transform.parent = attachPoint.transform;
        } 
    }
}
