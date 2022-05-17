using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerfursorScript : MonoBehaviour
{
    public static PerfursorScript singleton;
    public GameObject attachPoint;
    public GameObject attachedPerfursor;
    public bool perfursorAttached = false;

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
            var newPerfursor = Instantiate(attachedPerfursor, attachPoint.transform.position, attachPoint.transform.rotation);
            newPerfursor.transform.parent = attachPoint.transform;

            //other.gameObject.transform.position = attachPoint.transform.position;
        }   
    }
}
