using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmpulleScript : MonoBehaviour
{
    public static AmpulleScript singleton;
    public GameObject topPart;
    public bool isBroken = false;

    // Start is called before the first frame update

    private void Awake()
    {
        singleton = this;
    }
    private void OnTriggerExit(Collider other) {
        
        if(other.tag == "ampulle")
        {
            Debug.Log("separated");
            isBroken = true;
            topPart.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            topPart.gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
    }
        
}

