using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerfursorScript : MonoBehaviour
{
    public GameObject attachPoint;
    public GameObject attachedItem;
    public GameObject needle;

    private void Start()
    {
        needle = null;    
    }
    private void OnCollisionEnter(Collision other)
    {
         if(other.gameObject.tag == "Perfursor")
        {
            MultipleObjectiveChecker.singleton.perfursorAttached = true;
            Destroy(other.gameObject);
            var newPerfursor = Instantiate(attachedItem, attachPoint.transform.position, attachPoint.transform.rotation);
            newPerfursor.transform.parent = attachPoint.transform;
        }
        if(other.gameObject.tag == "Needle")
        {
            MultipleObjectiveChecker.singleton.needleAttached = true;
            Destroy(other.gameObject);
            var newSyringe = Instantiate(attachedItem, attachPoint.transform.position, attachPoint.transform.rotation);
            newSyringe.transform.parent = attachPoint.transform;
        }  
        if(other.gameObject.tag == "NeedleFilter")
        {
            MultipleObjectiveChecker.singleton.needleFilterAttached = true;
            Destroy(other.gameObject);
            var newFilter = Instantiate(attachedItem, attachPoint.transform.position, attachPoint.transform.rotation);
            newFilter.transform.parent = attachPoint.transform;
            needle = newFilter;
        } 
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "NeedleFilter")
        {
            Debug.Log("separated");
            if(needle != null)
            {
                needle.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                needle.gameObject.GetComponent<Rigidbody>().useGravity = true;
            }
        }
    }
}
